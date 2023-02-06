using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cuotas : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
        int cuotaid;
        int cuotadetalleid;
        int auxcantcuotaspagas;
        int cuotas;
        float monto;
        float auxtotalMontoPago;
        float Tpago;
        int Tcuot;
        int cuoestado;

        public Cuotas()
        {
            InitializeComponent();
            buttonEliminar.Enabled = false;
            buttonModificar.Enabled = false;
        }

        public void Estado()
        {
            conexion.Open();
            string sql = "SELECT CuoEs_Id,CuoEs_Descripcion FROM cuotaestado";
            MySqlDataAdapter adaptador1 = new MySqlDataAdapter();
            adaptador1.SelectCommand = new MySqlCommand(sql, conexion);

            DataTable tabla = new DataTable();
            adaptador1.Fill(tabla);
            tabla.Rows.Add(0, "Selecciona Estado");
            tabla.DefaultView.Sort = "CuoEs_Id";

            comboEstado.DataSource = tabla;
            comboEstado.DisplayMember = "CuoEs_Descripcion";
            comboEstado.ValueMember = "CuoEs_Id";
            conexion.Close();
        }

        private bool ValidarFecha()
        {

            DateTime hoy = DateTime.Today;
            if (dateTimePicker1.Value.Date == hoy )
            {
                return false;
            }
            return true;
        }

        private void CalcularDias()
        {
           
                DateTime FechaEntrega = dateTimePicker1.Value;

                DateTime FechaDev = dateTimePicker2.Value;

                TimeSpan tspan = FechaDev - FechaEntrega;
                int dias = tspan.Days + 1;
                if (dias > 25)
                {
                    MessageBox.Show("La fecha de pago no puede sobrepasar los 25 dias. ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

        }


        private void buttonGrabar_Click(object sender, EventArgs e)
        {
            CalcularDias();
            if (textDni.Text=="")
            {
                MessageBox.Show("Debe ingresar un DNI para buscar cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDni.Focus();
                return;
            }
            if (ExisteCuotaSocio())
            {
                MessageBox.Show("El cliente ya tiene registrado una forma de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDni.Focus();
                return;
            }
            if (comboCantCuotas.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar la cantidad de cuotas.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboCantCuotas.Focus();
                return;
            }
            if (comboMes.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar el mes a pagar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboMes.Focus();
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Debe seleccionar cantidad de cuotas que paga.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDni.Focus();
                return;
            }
       
            if (comboMonto.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar monto de la cuota.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboMonto.Focus();
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Debe ingresar el pago total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDni.Focus();
                return;
            }
            if (int.Parse(comboEstado.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Debe seleccionar estado del pago.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboEstado.Focus();
                return;
            }
            else
            {
                conexion.Open();

                string sql = "INSERT INTO cuota (Cuo_Mes,Cuo_Fech_Egreso,Cuo_Fecha_Pago,Cuo_CuoEs_id ) VALUES " +
                    "(@mes,@fegreso , @fpago, @estado)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@mes", MySqlDbType.VarChar).Value = comboMes.SelectedItem;
                comando.Parameters.Add("@fegreso", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
                comando.Parameters.Add("@fpago", MySqlDbType.Date).Value = dateTimePicker2.Value.Date;
                comando.Parameters.Add("@estado", MySqlDbType.Int16).Value = comboEstado.SelectedValue.ToString();
                comando.ExecuteNonQuery();

                string sql1 = "SELECT  MAX(Cuo_Id) AS 'id' FROM cuota";
                MySqlCommand comando2 = new MySqlCommand(sql1, conexion);
                MySqlDataReader registrouno = comando2.ExecuteReader();
                if (registrouno.Read())
                {
                    label11.Text = registrouno["id"].ToString();//guardo id cuota
                }
                registrouno.Close();

                string sql0 = "SELECT Cuo_CuoEs_Id FROM cuota  " +
                    "WHERE Cuo_Id = @idcuota"; 
                MySqlCommand comando0 = new MySqlCommand(sql0, conexion);
                comando0.Parameters.Add("@idcuota", MySqlDbType.Int32).Value = label11.Text;
                MySqlDataReader registro0 = comando0.ExecuteReader();
                if (registro0.Read())
                {
                    cuoestado =int.Parse( registro0["Cuo_CuoEs_Id"].ToString());//guardo id de estado
                }
                registro0.Close();

              

                string sql2 = "INSERT INTO cuotadetalle (CuoDet_Monto,CuoDet_Total,CuoDet_Cantidad,CuoDet_Cuotanumero,CuoDet_Nota,CuoDet_MontoPago,CuoDet_CantCuotasPagas,CuoDet_Cuo_Id,CuoDet_Soc_Id) " +
                    "VALUES  (@monto, @total, @cantcuotas, @cuotanum, @notas,@totalpago,@cuotaspagas, @cuotaid, @socio)";
                MySqlCommand comando3 = new MySqlCommand(sql2, conexion);
                comando3.Parameters.Add("@monto", MySqlDbType.Float).Value = comboMonto.SelectedItem;
                comando3.Parameters.Add("@total", MySqlDbType.Float).Value = textBox3.Text;
                cuotas = int.Parse(textBox4.Text);
                monto = float.Parse(textBox3.Text);
                comando3.Parameters.Add("@cantcuotas", MySqlDbType.Int16).Value = comboCantCuotas.SelectedItem;
                comando3.Parameters.Add("@cuotanum", MySqlDbType.Int16).Value = textBox4.Text;
                comando3.Parameters.Add("@notas", MySqlDbType.VarChar).Value = textBox2.Text;
               
                if (cuoestado == 1)
                {
                    comando3.Parameters.Add("@cuotaspagas", MySqlDbType.Int16).Value = cuotas.ToString();
                    comando3.Parameters.Add("@totalpago", MySqlDbType.Float).Value = monto.ToString();
                }
                else
                {
                    comando3.Parameters.Add("@cuotaspagas", MySqlDbType.Int16).Value = 0;
                    comando3.Parameters.Add("@totalpago", MySqlDbType.Float).Value = 0;
                }

                
                
                comando3.Parameters.Add("@cuotaid", MySqlDbType.Int16).Value = label11.Text;
                comando3.Parameters.Add("@socio", MySqlDbType.Int16).Value = label13.Text;

                int cant = comando3.ExecuteNonQuery();
                conexion.Close();

                 if (cant == 1)
                {
                   
                    MessageBox.Show("Se guardaron con exito los datos ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
                else
                {
                    MessageBox.Show("No se pudo guardar los cambios ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Limpiar();
            }
        }

        private void Limpiar()
        {
            textDni.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label13.Text = "";
            label11.Text = "";
            comboCantCuotas.SelectedIndex = 0;
            comboEstado.SelectedIndex = 0;
            comboMes.SelectedIndex = 0;
            comboMonto.SelectedIndex = 0;
            comboEstado.SelectedIndex = 0;

            buttonEliminar.Enabled = false;
            buttonModificar.Enabled = false;
        }

        private bool ExisteCuotaSocio()
        {
            conexion.Open();
            string sql = "SELECT CuoDet_Soc_Id FROM cuotadetalle  " +
                "JOIN socio ON Soc_Id = CuoDet_Soc_Id " +
                "WHERE Soc_Dni = @dni";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textDni.Text;
            bool existe = false;
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {

                existe = true;
            }
            conexion.Close();
            return existe;
        }

        private bool CuotasVencidas()
        {
            conexion.Open();
            string sql = "SELECT Cuo_Fecha_Pago,Cuo_CuoEs_Id FROM cuota " +
                "JOIN cuotadetalle ON CuoDet_Cuo_Id = Cuo_Id " +
                "JOIN socio ON Soc_Id = CuoDet_Soc_Id " +
                "WHERE Soc_Dni = @dni AND Cuo_Fecha_Pago<NOW() AND Cuo_CuoEs_Id = 2";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textDni.Text;
            bool existe = false;
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {

                existe = true;
            }
            conexion.Close();
            return existe;
        }

        private void Cuotas_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            dateTimePicker1.Enabled = false;
            Estado();
        }

        private void buttonBuscarNom_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string sql3 = "SELECT Soc_Id,Soc_Nombre, Soc_Apellido FROM socio " +
           "WHERE Soc_Dni = @dni";
            MySqlCommand comando4 = new MySqlCommand(sql3, conexion);
            comando4.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textDni.Text;
            MySqlDataReader registro4 = comando4.ExecuteReader();
            if (registro4.Read())
            {
                label13.Text = registro4["Soc_Id"].ToString();
                textBox1.Text = registro4["Soc_Nombre"].ToString() + "  " + registro4["Soc_Apellido"].ToString();//guardo id cuota
            }
            registro4.Close();
            conexion.Close();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if (textDni.Text == "")
            {
                MessageBox.Show("Debe ingresar un DNI para buscar cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDni.Focus();
                return;
            }
            else
            {

                conexion.Open();
                string sql = "SELECT Soc_Nombre,Soc_Apellido,CuoDet_Id,CuoDet_Cantidad,Cuo_Mes,CuoDet_Cuotanumero,Cuo_Id,Cuo_Fech_Egreso,Cuo_Fecha_Pago,CuoDet_Monto,CuoDet_Total,Cuo_CuoEs_Id,CuoDet_Nota,CuoDet_MontoPago,CuoDet_CantCuotasPagas FROM cuotadetalle  " +
                    "JOIN socio ON Soc_Id = CuoDet_Soc_Id " +
                    "JOIN cuota ON Cuo_Id = CuoDet_Cuo_Id " +
                    "WHERE Soc_Dni = @dni";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textDni.Text;
                MySqlDataReader registros = comando.ExecuteReader();


                bool existe = false;
                while (registros.Read())
                {

                    existe = true;
                    auxcantcuotaspagas = int.Parse(registros["CuoDet_Cuotanumero"].ToString());
                    auxtotalMontoPago = float.Parse(registros["CuoDet_Total"].ToString());

                    Tcuot= int.Parse(registros["CuoDet_CantCuotasPagas"].ToString());
                    Tpago = float.Parse(registros["CuoDet_MontoPago"].ToString());

                    cuotaid = int.Parse(registros["Cuo_Id"].ToString());
                    cuotadetalleid = int.Parse(registros["CuoDet_Id"].ToString());


                    textBox1.Text = registros["Soc_Nombre"].ToString() + "  " + registros["Soc_Apellido"].ToString();
                    comboCantCuotas.SelectedItem = registros["CuoDet_Cantidad"].ToString();
                    comboMes.SelectedItem = registros["Cuo_Mes"].ToString();
                    textBox4.Text = registros["CuoDet_Cuotanumero"].ToString();
                    dateTimePicker1.Text = registros["Cuo_Fech_Egreso"].ToString();
                    dateTimePicker2.Text = registros["Cuo_Fecha_Pago"].ToString();
                    comboMonto.SelectedItem = registros["CuoDet_Monto"].ToString();
                    textBox3.Text = registros["CuoDet_Total"].ToString();
                    monto = float.Parse(registros["CuoDet_Total"].ToString());
                    comboEstado.SelectedValue = registros["Cuo_CuoEs_Id"].ToString();
                    textBox2.Text = registros["CuoDet_Nota"].ToString();
                    buttonModificar.Enabled = true;
                    buttonEliminar.Enabled = true;

                }
                conexion.Close();
                if (existe == false)
                {
                    MessageBox.Show("No existe cuota para ese socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
          public void calcularTotalapagar()
       {
            auxcantcuotaspagas = int.Parse(textBox4.Text);
            monto = float.Parse(comboMonto.Text);
            auxtotalMontoPago = auxcantcuotaspagas * monto;
          
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = "UPDATE cuotadetalle SET  CuoDet_Cantidad=@cant,CuoDet_Cuotanumero=@num,CuoDet_Monto=@monto,CuoDet_Total=@total, " +
                "CuoDet_Nota = @nota " +
                "WHERE CuoDet_Id = @cuodetalleid";
            MySqlCommand comando1 = new MySqlCommand(sql, conexion);
            comando1.Parameters.Add("@cant", MySqlDbType.Int16).Value = comboCantCuotas.SelectedItem; ;
            comando1.Parameters.Add("@num", MySqlDbType.Int16).Value = textBox4.Text;
            comando1.Parameters.Add("@monto", MySqlDbType.Float).Value = comboMonto.SelectedItem;
            comando1.Parameters.Add("@total", MySqlDbType.Float).Value = textBox3.Text;
            comando1.Parameters.Add("@nota", MySqlDbType.VarChar).Value = textBox2.Text;
            comando1.Parameters.Add("@cuodetalleid", MySqlDbType.Int16).Value = cuotadetalleid;
            int cant = comando1.ExecuteNonQuery();


            string sql1 = "update cuota set Cuo_Mes=@mes,Cuo_Fecha_Pago=@fechapago,Cuo_CuoEs_Id=@estado " +
                " WHERE Cuo_Id = @idcuota";
            MySqlCommand comando2 = new MySqlCommand(sql1, conexion);
            comando2.Parameters.Add("@mes", MySqlDbType.VarChar).Value = comboMes.SelectedItem; 
            comando2.Parameters.Add("@fechapago", MySqlDbType.Date).Value = dateTimePicker2.Value.Date;
            comando2.Parameters.Add("@estado", MySqlDbType.Int16).Value = comboEstado.SelectedValue.ToString();
            comando2.Parameters.Add("@idcuota", MySqlDbType.Int16).Value = cuotaid;
            int cant1 = comando2.ExecuteNonQuery();


            conexion.Close();
            if (cant1 == 1  )
            {
               

                MessageBox.Show("Los datos fueron actualizados");

            }
            else
            {
                MessageBox.Show("No se pudo actualizar ");
            }
            Limpiar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Confirma Eliminar?", "Eliminar", MessageBoxButtons.YesNo);
           if(dr == DialogResult.Yes)
            {
                ConfirmarEliminar();
            }


        }

        private void ConfirmarEliminar()
        {
            conexion.Open();
            string sql = "DELETE FROM cuotadetalle WHERE CuoDet_Id=@idcuodetalle";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@idcuodetalle", MySqlDbType.Int16).Value = cuotadetalleid;
            int cant = comando.ExecuteNonQuery();

            string sql1 = "DELETE FROM cuota WHERE Cuo_Id=@cuoid";
            MySqlCommand comando1 = new MySqlCommand(sql1, conexion);
            comando1.Parameters.Add("@cuoid", MySqlDbType.Int16).Value = cuotaid;
            int cant1 = comando1.ExecuteNonQuery();


            conexion.Close();

            MessageBox.Show("Se elimino la cuota exitosamente!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpiar();

        }

        private void buttonPagarCuota_Click(object sender, EventArgs e)
        {
            PgarCuota pagar = new PgarCuota();
            pagar.ShowDialog();
        }

        private void buttonRepIngresos_Click(object sender, EventArgs e)
        {
            ReportesIngresos reporte = new ReportesIngresos();
            reporte.ShowDialog();
        }

        private void buttonRepMorosos_Click(object sender, EventArgs e)
        {
            ReporteMorosos rm = new ReporteMorosos();
            rm.ShowDialog();
        }
    }
}

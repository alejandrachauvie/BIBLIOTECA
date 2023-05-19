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
    public partial class PgarCuota : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
        int cantcuotas;
        int tpagascuo;
        int CaPagar;
        int paga;
        float total;
        float totalFinal;
        int cuota;
        int cuotapaga;
        int idcuota;
        int idcuotadetalle;
        float montopago;
        float finalpago;
        int cuotaNum;
        int socio;
        int cuotaid;
        public PgarCuota()
        {
            InitializeComponent();
            textSocio.Enabled = false;
            textcuotaspagas.Enabled = false;
            combomonto.Enabled = false;
            combomes.Enabled = false;
            dateTimePicker1.Enabled = false;
            textcuorestantes.Enabled = false;
            textBox4.Enabled = false;
            textBox1.Enabled = false;
        }

        private void buttonBuscarDni_Click(object sender, EventArgs e)
        {
          
            conexion.Open();
            string sql = "SELECT Soc_Id,Soc_Nombre,Soc_Apellido,Cuo_Fech_Egreso,CuoDet_Id,CuoDet_CantCuotasPagas,Cuo_Id,Cuo_Mes,CuoDet_Monto,CuoDet_MontoPago, CuoDet_Cantidad,Cuo_CuoEs_Id,CuoEs_Descripcion FROM cuotadetalle  " +
                "JOIN socio ON Soc_Id = CuoDet_Soc_Id " +
                "JOIN cuota ON Cuo_Id = CuoDet_Cuo_Id " +
                "JOIN cuotaestado ON CuoEs_Id = Cuo_CuoEs_Id " +
                "WHERE Soc_Dni = @dni ";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textDni.Text;
            MySqlDataReader registros = comando.ExecuteReader();


            bool existe = false;
            while (registros.Read())
            {

                existe = true;
                socio =int.Parse(registros["Soc_Id"].ToString());
                textSocio.Text = registros["Soc_Nombre"].ToString() + "  " + registros["Soc_Apellido"].ToString();
                dateTimePicker1.Text= registros["Cuo_Fech_Egreso"].ToString();
                textcuotaspagas.Text= registros["CuoDet_CantCuotasPagas"].ToString();
                combomes.SelectedItem = registros["Cuo_Mes"].ToString();
                combomonto.SelectedItem = registros["CuoDet_Monto"].ToString();

                idcuota = int.Parse(registros["Cuo_Id"].ToString());
                idcuotadetalle = int.Parse(registros["CuoDet_Id"].ToString());

                totalFinal = float.Parse(registros["CuoDet_Monto"].ToString());
                cantcuotas= int.Parse(registros["CuoDet_Cantidad"].ToString());
                tpagascuo = int.Parse(registros["CuoDet_CantCuotasPagas"].ToString());
                montopago = float.Parse(registros["CuoDet_MontoPago"].ToString());
                CaPagar = cantcuotas - tpagascuo;
                textcuorestantes.Text = CaPagar.ToString();
                Apagar();
                Totalapagar();

            }
            conexion.Close();
            if (existe == false)
            {
                MessageBox.Show("No existe cuota para ese socio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            conexion.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void Apagar()
        {
            paga = tpagascuo + 1;
            textBox4.Text = paga.ToString();
        }

        public void Totalapagar()
        {
            cuotapaga = int.Parse(textcuotaspagas.Text);
            cuota = paga - cuotapaga;
            total = totalFinal * cuota;
            textBox1.Text = total.ToString();


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

        private void buttonGrabar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar mes que paga.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Focus();
                return;
            }
            else
            {
                conexion.Open();
                string sql = "INSERT INTO cuota (Cuo_Mes,Cuo_Fech_Egreso,Cuo_Fecha_Pago,Cuo_CuoEs_id ) VALUES " +
                    "(@mes,@fegreso , @fpago, @estado)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                DateTime hoy = DateTime.Today;
                comando.Parameters.Add("@mes", MySqlDbType.VarChar).Value = comboBox1.SelectedItem;
                comando.Parameters.Add("@fegreso", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
                comando.Parameters.Add("@fpago", MySqlDbType.Date).Value = hoy;
                comando.Parameters.Add("@estado", MySqlDbType.Int16).Value = comboEstado.SelectedValue.ToString();
                int cant00 = comando.ExecuteNonQuery();

                string sql1 = "SELECT  MAX(Cuo_Id) AS 'id' FROM cuota";
                MySqlCommand comando2 = new MySqlCommand(sql1, conexion);
                MySqlDataReader registrouno = comando2.ExecuteReader();
                if (registrouno.Read())
                {
                    cuotaid = int.Parse(registrouno["id"].ToString());//guardo id cuota
                }
                registrouno.Close();


                finalpago = montopago + totalFinal;

                string sql2 = "INSERT INTO cuotadetalle (CuoDet_Monto,CuoDet_Total,CuoDet_Cantidad,CuoDet_Cuotanumero,CuoDet_Nota,CuoDet_MontoPago,CuoDet_CantCuotasPagas,CuoDet_Cuo_Id,CuoDet_Soc_Id) " +
                   "VALUES  (@monto, @total, @cantcuotas, @cuotanum,'Cuota paga',@totalpago,@cuotaspagas, @cuotaid, @socio)";
                MySqlCommand comando1 = new MySqlCommand(sql2, conexion);
                comando1.Parameters.Add("@monto", MySqlDbType.Float).Value = combomonto.SelectedItem;
                comando1.Parameters.Add("@total", MySqlDbType.Float).Value = textBox1.Text;
                comando1.Parameters.Add("@cantcuotas", MySqlDbType.Int32).Value = cantcuotas;
                comando1.Parameters.Add("@cuotanum", MySqlDbType.Int32).Value = textBox4.Text;
                comando1.Parameters.Add("@totalpago", MySqlDbType.Float).Value = combomonto.SelectedItem;
                comando1.Parameters.Add("@cuotaspagas", MySqlDbType.Int32).Value = textBox4.Text;
                comando1.Parameters.Add("@cuotaid", MySqlDbType.Int32).Value = cuotaid;
                comando1.Parameters.Add("@socio", MySqlDbType.Int32).Value = socio ;



                int cant1 = comando1.ExecuteNonQuery();

                conexion.Close();
                if (cant1 == 1)
                {


                    MessageBox.Show("Págo realizado");

                }
                else
                {
                    MessageBox.Show("No se pudo realizar el págo. ");
                }

                Limpiar();
            }
        }

        private void Limpiar()
        {
            textDni.Text = "";
            textSocio.Text = "";
            combomes.SelectedIndex = 0;
            combomonto.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            textcuorestantes.Text = "";
            textcuotaspagas.Text = "";
            textBox4.Text = "";
            textBox1.Text = "";
            comboEstado.SelectedIndex = 0;

        }

        private void PgarCuota_Load(object sender, EventArgs e)
        {
            Estado();
        }

        
    }
}

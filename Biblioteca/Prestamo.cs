
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Activities.Expressions;
using System.Activities.Statements;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace WindowsFormsApp1
{
    public partial class Prestamo : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
        int libropres;
        string idprestamo;
        int cantidad;
        string estadopres;
        int total;
        int pos;
        int considPres;
        int stockid,stockidAux;
        int idlibroAux;
        string tituloAux;
        string autorAux;
        String editorialAux;
        int libroid;
        int id_libMod;
        int id_stockMod;
        int id_Pres;
        int stockMod;
        int presdetalle;
        int idLibro;
        int stockId;
        int stock_Total;
        string dni;



        public Prestamo()
        {
            InitializeComponent();
            desabilitar();
            
        }

        private void Prestamo_Load(object sender, EventArgs e)
        {
            MostrarTabla();

           
        }

        public void desabilitar()
        {
            buttonModificar.Enabled = false;
            buttonEliminar.Enabled = false;
            checkBoxIntercambiar.Enabled=false;
            BDevolver.Enabled = false;
            dateTimePicker1.Enabled = false;
          

        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = "SELECT  Soc_Id,Soc_Nombre,Soc_Apellido FROM socio WHERE Soc_Dni = @dni";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textBoxDni.Text;

            MySqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                label13.Text = registro["Soc_Id"].ToString();// guardo id socio
                textBoxNombre.Text = registro["Soc_Nombre"].ToString();
                textBoxApellido.Text = registro["Soc_Apellido"].ToString();


            }
            else
            {
                MessageBox.Show("No existe un Socio con ese DNI");

            }
            conexion.Close();
        }

        //verificar el cliente no tenga mas de 3 prestamos otorgados


        public bool prestamosOtorgados()
        {
            conexion.Open();
            string sql = "SELECT Pres_Soc_Id FROM prestamo " +
                "JOIN socio ON Soc_Id = Pres_Soc_id " +
                "WHERE Soc_Dni = @dni AND Pres_PresEs_Id=1";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textBoxDni.Text;
            bool existe = false;
            MySqlDataReader registro = comando.ExecuteReader();
            int cantLibros = 0;
            while(registro.Read())
            {
                registro["Pres_Soc_Id"].ToString();
                cantLibros = cantLibros + 1;
            }
            if (cantLibros >= 3)
            {
                existe = false;
            }
            else
            {
                existe = true;
            }
            conexion.Close();
            return existe;

        }

        //verificar si hay stock disponible para prestamo
        private bool stockDisponible()
        {
            conexion.Open();
            string sql = "SELECT stock_id,stock_total FROM stock " +
                "JOIN libro ON Stock_stock_id = stock_id " +
                "WHERE Lib_Titulo = @titulo and Lib_LibEs_Id=1";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = textBoxTitulo.Text;
            bool existe = false;
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                stockid= int.Parse(registro["stock_id"].ToString());
                total = int.Parse(registro["stock_total"].ToString());
                int cantidad= int.Parse(registro["stock_total"].ToString());
                if (cantidad > 0)
                {
                    existe = true;
                }
                else
                {
                    existe = false;

                }
            }
           

                
            conexion.Close();
            return existe;
        }

        //buscar libro
        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string sql1 = "SELECT Lib_Id,Lib_Aut_id,Aut_Nombre, Edit_Nombre FROM libro  " +
                "JOIN autor ON Aut_Id = Lib_Aut_id " +
                "JOIN editorial ON Edit_id = Lib_Edit_id " +
                "WHERE Lib_Titulo = @libro";
            MySqlCommand comando = new MySqlCommand(sql1, conexion);
            comando.Parameters.Add("@libro", MySqlDbType.VarChar).Value = textBoxTitulo.Text;

            MySqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                libroid = int.Parse(registro["Lib_Id"].ToString());// guardo id libro guardar en una variable
                label14.Text= registro["Lib_Id"].ToString();// guardo id libro guardar en una variable
                textBoxAutor.Text = registro["Aut_Nombre"].ToString();
                textBoxEditorial.Text = registro["Edit_Nombre"].ToString();

            }
            else
            {
                MessageBox.Show("No existe ese Libro");

            }
            conexion.Close();
        }
        private bool ValidarFecha()
        {

            DateTime hoy = DateTime.Today;
            if (dateTimePicker1.Value.Date == hoy)
            {
                return false;
            }
            return true;
        }

        private bool CalcularDias()
        {
        
            
                 bool existe = false;
                DateTime FechaEntrega = dateTimePicker1.Value;

                DateTime FechaDev = dateTimePicker2.Value;

                TimeSpan tspan = FechaDev - FechaEntrega;
                int dias = tspan.Days +1;
                if (dias > 7)
                {
                   
                    existe = true;
                }
                else
                {
                    label11.Text = dias.ToString();

                }
                return existe;
            

        }

        public void Limpiar()
        {
            textBoxDni.Text = "";
            textBoxTitulo.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxAutor.Text = "";
            textBoxEditorial.Text = "";
            label14.Text = "";
            label17.Text = "";
            label18.Text = "";
            label21.Text = "";
            label11.Text = "";
            estadopres ="";
            tituloAux="";
            autorAux="";
            editorialAux="";
            textBoxConsultar.Text = "";
            textBoxDni.Enabled = true;
            BDevolver.Enabled = false;
            

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            buttonGrabar.Enabled = true;
            buttonEliminar.Enabled = false;
            buttonModificar.Enabled = false;
            MostrarTabla();
            
        }
        public void MostrarTabla()
        {
            conexion.Open();
            string sql = "SELECT Pres_Id,Pres_Fecha_Entrega,Pres_Fech_Dev,Pres_PresEs_Id,Pres_Soc_Id,Soc_Dni,Soc_Nombre,Soc_Apellido,Soc_Telef,Lib_Id,Lib_Titulo,Aut_Nombre,Edit_Nombre,stock_id,stock_cantidad,stock_total,Usu_Id,Usu_Nombre FROM prestamo    " +
                "JOIN socio ON Soc_Id = Pres_Soc_Id " +
                "JOIN prestamodetalle ON PresDet_Pres_Id = Pres_Id " +
                "JOIN libro ON Lib_Id = PresDet_Lib_Id " +
                "JOIN autor ON Aut_Id = Lib_Aut_Id " +
                "JOIN editorial ON Edit_Id = Lib_Edit_Id " +
                "JOIN stock ON stock_id = Stock_stock_id " +
                "JOIN usuario ON Usu_Id = Pres_Usu_Id " +
                "WHERE Pres_PresEs_Id = 1";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registro = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registro.Read())
            {
                stockidAux = int.Parse(registro["stock_id"].ToString());
                idlibroAux= int.Parse(registro["Lib_Id"].ToString());
             
                dataGridView1.Rows.Add(registro["Pres_Id"].ToString(),
                                    registro["Soc_Dni"].ToString(),
                                    registro["Soc_Nombre"].ToString(),
                                    registro["Soc_Apellido"].ToString(),
                                    registro["Soc_Telef"].ToString(),
                                    registro["Lib_Titulo"].ToString(),
                                    registro["Aut_Nombre"].ToString(),
                                    registro["Edit_Nombre"].ToString(),
                                    registro["Pres_Fecha_Entrega"].ToString(),
                                    registro["Pres_Fech_Dev"].ToString(),
                                    registro["stock_cantidad"].ToString(),
                                    registro["stock_total"].ToString(),
                                    registro["Usu_Nombre"].ToString());

            }
            registro.Close();
            conexion.Close();



        }
        private bool CuotasVencidas()
        {
            conexion.Open();
            string sql = "SELECT Cuo_Fecha_Pago,Cuo_CuoEs_Id FROM cuota " +
                "JOIN cuotadetalle ON CuoDet_Cuo_Id = Cuo_Id " +
                "JOIN socio ON Soc_Id = CuoDet_Soc_Id " +
                "WHERE Soc_Dni = @dni AND Cuo_Fecha_Pago<NOW() AND Cuo_CuoEs_Id = 2";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textBoxDni.Text;
            bool existe = false;
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {

                existe = true;
            }
            conexion.Close();
            return existe;
        }

        private bool PagosVencidos()
        {
            conexion.Open();
            string sql = "SELECT Cuo_Mes,Cuo_Fecha_Pago,Cuo_CuoEs_Id FROM cuota  " +
                "JOIN cuotadetalle ON CuoDet_Cuo_Id = Cuo_Id " +
                "JOIN socio ON Soc_Id = CuoDet_Soc_Id " +
                "WHERE Soc_Dni = @dni ";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textBoxDni.Text;
            MySqlDataReader registro = comando.ExecuteReader();
            bool existe = false;
            DateTime hoy = DateTime.Today;
            if (registro.Read())
            {
                DateTime fechapago = DateTime.Parse(registro["Cuo_Fecha_Pago"].ToString());
                TimeSpan tspan =  hoy - fechapago;
                int dias = tspan.Days +1;
              
                
                if (dias < 40)
                {
                   
                    existe = true;

                }
               

                

            }
            conexion.Close();
            return existe;
           
            
        }




        private void buttonGrabar_Click(object sender, EventArgs e)
        {
              

            if (CalcularDias())
            {
                MessageBox.Show("El prestamo son de 7 días maximo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxDni.Focus();
                return;

            }


            if (textBoxDni.Text == "" )
            {
                MessageBox.Show("Debes ingresar dni y buscar socio que retira ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDni.Focus();
                return;

            }
            if (textBoxTitulo.Text == "")
            {
                MessageBox.Show("Debes ingresar el libro a prestar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTitulo.Focus();
                return;

            }
          
            if (!stockDisponible())
            {
                MessageBox.Show("No quedan libros en stock , para realizar el prestamo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!prestamosOtorgados())
            {

                MessageBox.Show("El socio a superado la capacidad de prestamos ", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (CuotasVencidas())
            {

                MessageBox.Show("El socio tiene cuotas vencidas, debe pagar para poder operar. ", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (PagosVencidos())
            {
                MessageBox.Show("El socio tiene pagos vencidos. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDni.Focus();
                return;

            }

            else
            {
                
                conexion.Open();
                string sqlusu = "SELECT  MAX(Ses_Id ) AS 'id',Ses_Usu_Id FROM sesion";
                MySqlCommand comando4 = new MySqlCommand(sqlusu, conexion);
                MySqlDataReader registro0 = comando4.ExecuteReader();
                if (registro0.Read())
                {
                    label17.Text = registro0["id"].ToString();// tengo guardado el id sesion
                }
                registro0.Close();

                string sqlc = "select Ses_Usu_Id FROM sesion " +
                   "WHERE Ses_Id = @idsesion";
                MySqlCommand comando6 = new MySqlCommand(sqlc, conexion);
                comando6.Parameters.Add("@idsesion", MySqlDbType.Int16).Value = label17.Text;
                MySqlDataReader registro6 = comando6.ExecuteReader();
                if (registro6.Read())
                {
                    label18.Text = registro6["Ses_Usu_Id"].ToString();// tengo guardado el id usuario
                }
                registro6.Close();

                string sql = "INSERT INTO prestamo (Pres_Fecha_Entrega,Pres_Fech_Dev,Pres_PresEs_Id,Pres_Soc_Id,Pres_Usu_id) " +
                     "VALUES (@fechentrega, @fechdev, 1, @socid,@idusuario)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                DateTime fecha = dateTimePicker1.Value.Date;
                comando.Parameters.Add("@fechentrega", MySqlDbType.Date).Value = fecha.ToString("yyyy/MM/dd");
                comando.Parameters.Add("@fechdev", MySqlDbType.Date).Value = dateTimePicker2.Value.Date;
                comando.Parameters.Add("@socid", MySqlDbType.Int16).Value = label13.Text;
                comando.Parameters.Add("@idusuario", MySqlDbType.Int16).Value = label18.Text;
                comando.ExecuteNonQuery();

                string sql1 = "SELECT Pres_Id FROM prestamo " +
                    "JOIN socio ON Soc_Id = Pres_Soc_Id " +
                    "WHERE Pres_Fecha_Entrega =@fechentrega AND Pres_Fech_Dev = @fechdev AND Pres_Soc_Id = @socid";
                MySqlCommand comando3 = new MySqlCommand(sql1, conexion);
                //DateTime fecha = dateTimePicker1.Value.Date;
                comando3.Parameters.Add("@fechentrega", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
                comando3.Parameters.Add("@fechdev", MySqlDbType.Date).Value = dateTimePicker2.Value.Date;
                comando3.Parameters.Add("@socid", MySqlDbType.Int16).Value = label13.Text;
                MySqlDataReader registro4 = comando3.ExecuteReader();
                if (registro4.Read())
                {
                    label21.Text = registro4["Pres_Id"].ToString();// tengo guardado el id del prestamo
                }
                registro4.Close();

                string sql2 = "INSERT prestamodetalle (PresDet_Cantidad,PresDet_Lib_Id,PresDet_Pres_Id) VALUES(1,@libroid,@presid)";
                MySqlCommand comando1 = new MySqlCommand(sql2, conexion);
                comando1.Parameters.Add("@libroid", MySqlDbType.Int16).Value = label14.Text;
                comando1.Parameters.Add("@presid", MySqlDbType.Int16).Value = label21.Text;
                comando1.ExecuteNonQuery();

                string sqlpres = "SELECT PresDet_Id, PresDet_Cantidad, PresEs_Descripcion,stock_id, stock_total FROM prestamodetalle " +
                    "JOIN libro ON Lib_Id = Presdet_Lib_Id " +
                    "JOIN prestamo ON Pres_Id = PresDet_Pres_Id " +
                    "JOIN prestamoestado ON PresEs_id = Pres_PresEs_id " +
                    "JOIN stock ON stock_id = Stock_stock_id " +
                    "WHERE Lib_Titulo = @libro";
                MySqlCommand comandop = new MySqlCommand(sqlpres, conexion);
                comandop.Parameters.Add("@libro", MySqlDbType.VarChar).Value = textBoxTitulo.Text;
               
                MySqlDataReader registrop = comandop.ExecuteReader();
                if (registrop.Read())
                {
                    label22.Text = registrop["stock_id"].ToString();// guardo id stock
                    idprestamo = registrop["PresDet_Id"].ToString();// tengo guardado el id del prestamodetalle
                     cantidad=int.Parse(registrop["PresDet_Cantidad"].ToString());//guardo cantidad en entero
                     estadopres= registrop["PresEs_Descripcion"].ToString();// tengo guardado estado prestamo '' en este caso prestado
                     total= int.Parse(registrop["stock_total"].ToString());//guardo total stock
                }
                registrop.Close();


                string sqlres = "UPDATE stock SET stock_cantidad = @cantidad ,stock_total=@total " +
                                "WHERE stock_id=@idstock";
                MySqlCommand comandor = new MySqlCommand(sqlres, conexion);
                comandor.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = 1;
                comandor.Parameters.Add("@total", MySqlDbType.Int32).Value = total - 1 ;
                comandor.Parameters.Add("@idstock", MySqlDbType.VarChar).Value = label22.Text;
                int cant00 = comandor.ExecuteNonQuery();

                conexion.Close();
                if (cant00 == 1)
                {
                   
                    MessageBox.Show("Se guardaron con exito los datos ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar los cambios ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Limpiar();
                MostrarTabla();

            }
          
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "stock_total")
            {
                if (Convert.ToInt32(e.Value) < 2)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.DarkSeaGreen;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = dataGridView1.CurrentRow.Index;
            textBoxDni.Enabled = false;
            textBoxDni.Text = dataGridView1[1, pos].Value.ToString();
            textBoxNombre.Text = dataGridView1[2, pos].Value.ToString();
            textBoxApellido.Text = dataGridView1[3, pos].Value.ToString();
            textBoxTitulo.Text = dataGridView1[5, pos].Value.ToString();
            textBoxAutor.Text = dataGridView1[6, pos].Value.ToString();
            textBoxEditorial.Text = dataGridView1[7, pos].Value.ToString();
            dateTimePicker1.Text = dataGridView1[8, pos].Value.ToString();
            dateTimePicker2.Text = dataGridView1[9, pos].Value.ToString();
            buttonGrabar.Enabled = false;
            BDevolver.Enabled = true;
          
            buttonModificar.Enabled = true;
            buttonEliminar.Enabled = true;
            checkBoxIntercambiar.Enabled=true;

           

            id_Pres=int.Parse(dataGridView1[0, pos].Value.ToString()); 
            tituloAux = dataGridView1[5, pos].Value.ToString();
            autorAux= dataGridView1[6, pos].Value.ToString();
            stockMod= int.Parse(dataGridView1[11, pos].Value.ToString());


        }

      

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (!stockDisponible())
            {
                MessageBox.Show("No quedan libros en stock , para realizar el prestamo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                CalcularDias();
                if (checkBoxIntercambiar.Checked)//hacer procedimiento almacenado
                {
                    conexion.Open();
                    string sql = "SELECT Lib_Id,Stock_stock_id FROM libro " +
                        "JOIN stock ON stock_id=Stock_stock_id " +
                        "WHERE Lib_Titulo=@titulo";
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    comando.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = tituloAux;
                    MySqlDataReader registro = comando.ExecuteReader();

                    if (registro.Read())
                    {
                        id_stockMod = int.Parse(registro["Stock_stock_id"].ToString());
                        id_libMod = int.Parse(registro["Lib_Id"].ToString());
                    }
                    registro.Close();

                    //devuelvo al stock libro que va a intercambiar 
                    string sqlres = "UPDATE stock SET stock_cantidad = @cantidad ,stock_total=@total " +
                               "WHERE stock_id=@idstock";
                    MySqlCommand comandor = new MySqlCommand(sqlres, conexion);
                    comandor.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = 1;
                    comandor.Parameters.Add("@total", MySqlDbType.Int32).Value = stockMod + 1;
                    comandor.Parameters.Add("@idstock", MySqlDbType.VarChar).Value = id_stockMod;
                    int cant00 = comandor.ExecuteNonQuery();

                    //modifico stock libro a entregar por el cambio 
                    string sqlent = "UPDATE stock SET stock_cantidad = @cantidad ,stock_total=@total " +
                               "WHERE stock_id=@idstock";
                    MySqlCommand comando1 = new MySqlCommand(sqlent, conexion);
                    comando1.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = 1;
                    comando1.Parameters.Add("@total", MySqlDbType.Int32).Value = total - 1;
                    comando1.Parameters.Add("@idstock", MySqlDbType.VarChar).Value = stockid;
                    int cant = comando1.ExecuteNonQuery();

                    string sqlusu = "SELECT  MAX(Ses_Id ) AS 'id',Ses_Usu_Id FROM sesion";
                    MySqlCommand comando4 = new MySqlCommand(sqlusu, conexion);
                    MySqlDataReader registro0 = comando4.ExecuteReader();
                    if (registro0.Read())
                    {
                        label17.Text = registro0["id"].ToString();// tengo guardado el id sesion
                    }
                    registro0.Close();

                    string sqlc = "select Ses_Usu_Id FROM sesion " +
                  "WHERE Ses_Id = @idsesion";
                    MySqlCommand comando6 = new MySqlCommand(sqlc, conexion);
                    comando6.Parameters.Add("@idsesion", MySqlDbType.Int16).Value = label17.Text;
                    MySqlDataReader registro6 = comando6.ExecuteReader();
                    if (registro6.Read())
                    {
                        label18.Text = registro6["Ses_Usu_Id"].ToString();// tengo guardado el id usuario
                    }
                    registro6.Close();


                    string sql1 = "UPDATE prestamo SET Pres_Fecha_Entrega=@entrega , Pres_Fech_Dev=@devolucion, Pres_Usu_Id=@usuario " +
                        "WHERE Pres_Id=@idpres";
                    MySqlCommand comando2 = new MySqlCommand(sql1, conexion);
                    comando2.Parameters.Add("@entrega", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    comando2.Parameters.Add("@devolucion", MySqlDbType.Date).Value = dateTimePicker2.Value.Date;
                    comando2.Parameters.Add("@usuario", MySqlDbType.Int32).Value = label18.Text;
                    comando2.Parameters.Add("@idpres", MySqlDbType.Int32).Value = id_Pres;
                    int cant0 = comando2.ExecuteNonQuery();

                    string sql2 = "UPDATE prestamodetalle SET PresDet_Lib_Id=@idLibro WHERE PresDet_Pres_Id=@presid";
                    MySqlCommand comando3 = new MySqlCommand(sql2, conexion);
                    comando3.Parameters.Add("@idLibro", MySqlDbType.Int32).Value = libroid;
                    comando3.Parameters.Add("@presid", MySqlDbType.Int32).Value = id_Pres;
                    int cant1 = comando3.ExecuteNonQuery();



                    conexion.Close();
                    Limpiar();
                    MostrarTabla();
                    MessageBox.Show("Los datos han sido modificados con Exito!! ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
                else
                {

                    MessageBox.Show("Debe seleccionar intercambiar para poder modificar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                MostrarTabla();

            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            
                ValidarPermisos validar = new ValidarPermisos();
                validar.ShowDialog();
                if(validar.existe == true)
            {
                conexion.Open();
                string sqlp = "SELECT Lib_Id,stock_stock_id FROM libro " +
                       "JOIN stock ON stock_id=Stock_stock_id " +
                       "WHERE Lib_Titulo=@titulo";
                MySqlCommand comandop = new MySqlCommand(sqlp, conexion);
                comandop.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = tituloAux;
                MySqlDataReader registrop = comandop.ExecuteReader();

                if (registrop.Read())
                {
                    id_stockMod = int.Parse(registrop["Stock_stock_id"].ToString());
                    id_libMod = int.Parse(registrop["Lib_Id"].ToString());
                }
                registrop.Close();

                //devuelvo a stock el libro antes de eliminar
                string sqlres = "UPDATE stock SET stock_cantidad = @cantidad ,stock_total=@total " +
                               "WHERE stock_id=@idstock";
                MySqlCommand comandor = new MySqlCommand(sqlres, conexion);
                comandor.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = 1;
                comandor.Parameters.Add("@total", MySqlDbType.Int32).Value = stockMod + 1;
                comandor.Parameters.Add("@idstock", MySqlDbType.VarChar).Value = id_stockMod;
                int cant00 = comandor.ExecuteNonQuery();


                string sql = "SELECT PresDet_Id FROM prestamodetalle " +
                    "JOIN prestamo ON Pres_Id = PresDet_Pres_Id " +
                    "JOIN libro ON Lib_Id = PresDet_Lib_Id " +
                    "JOIN socio ON Soc_Id = Pres_Soc_Id " +
                    "WHERE Soc_Dni = @dni AND Lib_Titulo = @titulo";
                     MySqlCommand comando = new MySqlCommand(sql, conexion);
                     comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textBoxDni.Text;
                     comando.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = tituloAux;
                     MySqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    presdetalle = int.Parse(registro["PresDet_Id"].ToString());// tengo guardado el id prestamodetalle
                }
                registro.Close();

                string sql1 = "DELETE FROM prestamodetalle WHERE PresDet_Id=@detallepres";
                MySqlCommand comando1 = new MySqlCommand(sql1, conexion);
                comando1.Parameters.Add("@detallepres", MySqlDbType.Int16).Value = presdetalle;
                int cant = comando1.ExecuteNonQuery();

                string sql2 = "DELETE FROM prestamo WHERE Pres_Id=@prestamo";
                MySqlCommand comando2 = new MySqlCommand(sql2, conexion);
                comando2.Parameters.Add("@prestamo", MySqlDbType.Int16).Value = id_Pres;
                int cant1 = comando2.ExecuteNonQuery();

                conexion.Close();
                if (cant1 == 1)
                {

                    MessageBox.Show("Se elimino el prestamo exitosamente!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar los datos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                Limpiar();
    
            }
          
                
                
            
        }

        

        private void buttonBuscarNom_Click_1(object sender, EventArgs e)
        {
            conexion.Open();
            if (radioButton1.Checked)
            {
                string sql = "SELECT Pres_Id,Pres_Fecha_Entrega,Pres_Fech_Dev,Pres_Soc_Id,Soc_Dni,Soc_Nombre,Soc_Apellido,Soc_Telef,Lib_Id,Lib_Titulo,Aut_Nombre,Edit_Nombre,stock_id,stock_cantidad,stock_total,Usu_Id,Usu_Nombre FROM prestamo  " +
                    "JOIN socio ON Soc_Id = Pres_Soc_Id  " +
                    "JOIN prestamodetalle ON PresDet_Pres_Id = Pres_Id  " +
                    "JOIN libro ON Lib_Id = PresDet_Lib_Id  " +
                    "JOIN autor ON Aut_Id = Lib_Aut_Id  " +
                    "JOIN editorial ON Edit_Id = Lib_Edit_Id  " +
                    "JOIN stock ON stock_id = Stock_stock_id  " +
                    "JOIN usuario ON Usu_Id = Pres_Usu_Id " +
                    "WHERE Soc_Nombre=@nombre";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = textBoxConsultar.Text;
                MySqlDataReader registro = comando.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (registro.Read())
                {
                    stockidAux = int.Parse(registro["stock_id"].ToString());
                    idlibroAux = int.Parse(registro["Lib_Id"].ToString());
                    dataGridView1.Rows.Add(registro["Pres_Id"].ToString(),
                                        registro["Soc_Dni"].ToString(),
                                        registro["Soc_Nombre"].ToString(),
                                        registro["Soc_Apellido"].ToString(),
                                        registro["Soc_Telef"].ToString(),
                                        registro["Lib_Titulo"].ToString(),
                                        registro["Aut_Nombre"].ToString(),
                                        registro["Edit_Nombre"].ToString(),
                                        registro["Pres_Fecha_Entrega"].ToString(),
                                        registro["Pres_Fech_Dev"].ToString(),
                                        registro["stock_cantidad"].ToString(),
                                        registro["stock_total"].ToString(),
                                        registro["Usu_Nombre"].ToString());

                }
                registro.Close();

            }
            else
            {

                string sql = "SELECT Pres_Id,Pres_Fecha_Entrega,Pres_Fech_Dev,Pres_Soc_Id,Soc_Dni,Soc_Nombre,Soc_Apellido,Soc_Telef,Lib_Id,Lib_Titulo,Aut_Nombre,Edit_Nombre,stock_id,stock_cantidad,stock_total,Usu_Id,Usu_Nombre FROM prestamo " +
                    "JOIN socio ON Soc_Id = Pres_Soc_Id  " +
                    "JOIN prestamodetalle ON PresDet_Pres_Id = Pres_Id " +
                    " JOIN libro ON Lib_Id = PresDet_Lib_Id  " +
                    "JOIN autor ON Aut_Id = Lib_Aut_Id  " +
                    "JOIN editorial ON Edit_Id = Lib_Edit_Id  " +
                    "JOIN stock ON stock_id = Stock_stock_id  " +
                    "JOIN usuario ON Usu_Id = Pres_Usu_Id " +
                    "WHERE Lib_Titulo=@titulo";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = textBoxConsultar.Text;
                MySqlDataReader registro = comando.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (registro.Read())
                {
                    stockidAux = int.Parse(registro["stock_id"].ToString());
                    idlibroAux = int.Parse(registro["Lib_Id"].ToString());
                    dataGridView1.Rows.Add(registro["Pres_Id"].ToString(),
                                        registro["Soc_Dni"].ToString(),
                                        registro["Soc_Nombre"].ToString(),
                                        registro["Soc_Apellido"].ToString(),
                                        registro["Soc_Telef"].ToString(),
                                        registro["Lib_Titulo"].ToString(),
                                        registro["Aut_Nombre"].ToString(),
                                        registro["Edit_Nombre"].ToString(),
                                        registro["Pres_Fecha_Entrega"].ToString(),
                                        registro["Pres_Fech_Dev"].ToString(),
                                        registro["stock_cantidad"].ToString(),
                                        registro["stock_total"].ToString(),
                                        registro["Usu_Nombre"].ToString());

                }
                registro.Close();


            }
            conexion.Close();
        }
        public void BuscarIdLibro()
        {
            conexion.Open();
            string sql = "SELECT Lib_Id FROM libro JOIN prestamodetalle ON PresDet_Pres_Id " +
                "JOIN prestamo ON Pres_Id = PresDet_Pres_Id " +
                "WHERE Lib_Titulo = @titulo AND Pres_Id =@id";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = textBoxTitulo.Text;
            comando.Parameters.Add("@id", MySqlDbType.Int32).Value = dataGridView1[0, pos].Value.ToString();
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                idLibro = int.Parse(registro["Lib_Id"].ToString());// guardo id libro a devolver
            }
            registro.Close();
            conexion.Close();

        }

        private void BDevolver_Click(object sender, EventArgs e)
        {
            BuscarIdLibro();
            buscarStock();
            Devolucion devolucion = new Devolucion();
            devolucion.textPrestamo.Text= dataGridView1[0, pos].Value.ToString();
            devolucion.TBDni.Text = textBoxDni.Text;
            devolucion.textLibro.Text= dataGridView1[5, pos].Value.ToString();
            devolucion.dtfechDev.Value = dateTimePicker2.Value;
            devolucion.labelIdLibro.Text = idLibro.ToString();
            devolucion.labelStock.Text = stockId.ToString();
            devolucion.labeltotal.Text = total.ToString();
           
 
            devolucion.Show();
           


        }

        private void buscarStock()
        {
            conexion.Open();
            string sql = "SELECT Stock_stock_id,stock_total FROM libro " +
                "JOIN stock ON stock_id = Stock_stock_id " +
                "WHERE Lib_Titulo = @titulo";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = textBoxTitulo.Text;
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                stockId = int.Parse(registro["Stock_stock_id"].ToString());// guardo id stock
                stock_Total = int.Parse(registro["stock_total"].ToString());// guardo stock total
                total = stock_Total + 1;
                
            }
            registro.Close();
            conexion.Close();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            ConsultarDevoluciones consultar = new ConsultarDevoluciones();
            consultar.Show();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

     
    }
}

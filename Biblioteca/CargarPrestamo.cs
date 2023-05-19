using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CargarPrestamo : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
        int libroid;
        int total;
        int stockid;
        string idprestamo;
        int cantidad;
        string estadopres;
        string tituloAux;
        int id_stockMod;
        int id_libMod;
        int stocktotalMod;
        int id_Pres;
        int presdetalle;


        public CargarPrestamo()
        {
            InitializeComponent();
            autoCompletar();
            desabilitar();
            autoCompletarLibro();
            


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataTable datos = new DataTable();
        void autoCompletar()
        {
            string sql = "SELECT Soc_Dni FROM socio";
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexion);
            adaptador.Fill(datos);

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i]["Soc_Dni"].ToString());

            }

            textDNI.AutoCompleteCustomSource = lista;
        }


        DataTable datos1 = new DataTable();
        void autoCompletarLibro()
        {
            string sql = "SELECT Lib_Titulo FROM libro";
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexion);
            adaptador.Fill(datos1);

            for (int i = 0; i < datos1.Rows.Count; i++)
            {
                lista.Add(datos1.Rows[i]["Lib_Titulo"].ToString());

            }

            textLibro.AutoCompleteCustomSource = lista;
        }



        public void desabilitar()
        {
            buttonEditar.Enabled = false;
            buttonEliminar.Enabled = false;
            dateTimePicker1.Enabled = false;
            labellimite.Visible = false;
         


        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = "SELECT  Soc_Id,Soc_Nombre,Soc_Apellido FROM socio WHERE Soc_Dni = @dni";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textDNI.Text;

            MySqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                label14.Text = registro["Soc_Id"].ToString();// guardo id socio
                textNombre.Text = registro["Soc_Nombre"].ToString();
                textApellido.Text = registro["Soc_Apellido"].ToString();


            }
            else
            {
                MessageBox.Show("No existe un Socio con ese DNI");

            }
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string sql1 = "SELECT Lib_Img,Lib_Id,Lib_Aut_id,Aut_Nombre, Edit_Nombre FROM libro  " +
                "JOIN autor ON Aut_Id = Lib_Aut_id " +
                "JOIN editorial ON Edit_id = Lib_Edit_id " +
                "WHERE Lib_Titulo = @libro";
            MySqlCommand comando = new MySqlCommand(sql1, conexion);
            comando.Parameters.Add("@libro", MySqlDbType.VarChar).Value = textLibro.Text;

            MySqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                MemoryStream ms = new MemoryStream((byte[])registro["Lib_Img"]);
                Bitmap bn = new Bitmap(ms);
                pictureBox1.Image = bn;
                libroid = int.Parse(registro["Lib_Id"].ToString());// guardo id libro guardar en una variable
                label18.Text = registro["Lib_Id"].ToString();// guardo id libro guardar en una variable
                textAutor.Text = registro["Aut_Nombre"].ToString();
                textEditorial.Text = registro["Edit_Nombre"].ToString();

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
            dateTimePicker2.MinDate = DateTime.Today;

            DateTime FechaDev = dateTimePicker2.Value;
           

            TimeSpan tspan = FechaDev - FechaEntrega;
            int dias = tspan.Days + 1;
          
            if (dias > 7 )
            {

                existe = true;
                labelDias.Text = dias.ToString();
                labellimite.Visible = true;
                labellimite.Text = "El prestamo no puede superar los 7 días ";

            }
            else
            {
                labelDias.Text = dias.ToString();
                labellimite.Visible = false;
            }
            return existe;


        }


        //verificar si hay stock disponible para prestamo
        private bool StockDisponible()
        {
            conexion.Open();
            string sql = "SELECT stock_id,stock_total FROM stock " +
                "JOIN libro ON Stock_stock_id = stock_id " +
                "WHERE Lib_Titulo = @titulo and Lib_LibEs_Id=1";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = textLibro.Text;
            bool existe = false;
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                stockid = int.Parse(registro["stock_id"].ToString());
                total = int.Parse(registro["stock_total"].ToString());
                int cantidad = total;
                if (cantidad > 0)
                {
                    existe = true;
                }
                else
                {
                    existe = false;

                }
               
            }


            return existe;

        }

        //verificar el cliente no tenga mas de 3 prestamos otorgados
        public bool prestamosOtorgados()
        {
            conexion.Open();
            string sql = "SELECT Pres_Soc_Id FROM prestamo " +
                "JOIN socio ON Soc_Id = Pres_Soc_id " +
                "WHERE Soc_Dni = @dni AND Pres_PresEs_Id=1";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textDNI.Text;
            bool existe = false;
            MySqlDataReader registro = comando.ExecuteReader();
            int cantLibros = 0;
            while (registro.Read())
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

        private void buttonGrabar_Click(object sender, EventArgs e)
        {
            if (CalcularDias())
            {
                MessageBox.Show("El prestamo son de 7 días maximo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textDNI.Focus();
                return;

            }


            if (textDNI.Text == "")
            {
                MessageBox.Show("Debes ingresar dni y buscar socio que retira ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDNI.Focus();
                return;

            }
            if (textLibro.Text == "")
            {
                MessageBox.Show("Debes ingresar el libro a prestar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textLibro.Focus();
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
          
         

            else
            {

                conexion.Open();
                string sqlusu = "SELECT  MAX(Ses_Id ) AS 'id',Ses_Usu_Id FROM sesion";
                MySqlCommand comando4 = new MySqlCommand(sqlusu, conexion);
                MySqlDataReader registro0 = comando4.ExecuteReader();
                if (registro0.Read())
                {
                    label15.Text = registro0["id"].ToString();// tengo guardado el id sesion 17
                }
                registro0.Close();

                string sqlc = "select Ses_Usu_Id FROM sesion " +
                   "WHERE Ses_Id = @idsesion";
                MySqlCommand comando6 = new MySqlCommand(sqlc, conexion);
                comando6.Parameters.Add("@idsesion", MySqlDbType.Int16).Value = label15.Text;
                MySqlDataReader registro6 = comando6.ExecuteReader();
                if (registro6.Read())
                {
                    label16.Text = registro6["Ses_Usu_Id"].ToString();// tengo guardado el id usuario 18
                }
                registro6.Close();

                string sql = "INSERT INTO prestamo (Pres_Fecha_Entrega,Pres_Fech_Dev,Pres_PresEs_Id,Pres_Soc_Id,Pres_Usu_id) " +
                     "VALUES (@fechentrega, @fechdev, 1, @socid,@idusuario)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                DateTime fecha = dateTimePicker1.Value.Date;
                comando.Parameters.Add("@fechentrega", MySqlDbType.Date).Value = fecha.ToString("yyyy/MM/dd");
                comando.Parameters.Add("@fechdev", MySqlDbType.Date).Value = dateTimePicker2.Value.Date;
                comando.Parameters.Add("@socid", MySqlDbType.Int16).Value = label14.Text;
                comando.Parameters.Add("@idusuario", MySqlDbType.Int16).Value = label16.Text;
                comando.ExecuteNonQuery();

                string sql1 = "SELECT Pres_Id FROM prestamo " +
                    "JOIN socio ON Soc_Id = Pres_Soc_Id " +
                    "WHERE Pres_Fecha_Entrega =@fechentrega AND Pres_Fech_Dev = @fechdev AND Pres_Soc_Id = @socid";
                MySqlCommand comando3 = new MySqlCommand(sql1, conexion);
                //DateTime fecha = dateTimePicker1.Value.Date;
                comando3.Parameters.Add("@fechentrega", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
                comando3.Parameters.Add("@fechdev", MySqlDbType.Date).Value = dateTimePicker2.Value.Date;
                comando3.Parameters.Add("@socid", MySqlDbType.Int16).Value = label14.Text;
                MySqlDataReader registro4 = comando3.ExecuteReader();
                if (registro4.Read())
                {
                    label17.Text = registro4["Pres_Id"].ToString();// tengo guardado el id del prestamo 21
                   textBoxnprestamo.Text= registro4["Pres_Id"].ToString();
                }
                registro4.Close();

                string sql2 = "INSERT prestamodetalle (PresDet_Cantidad,PresDet_Lib_Id,PresDet_Pres_Id) VALUES(1,@libroid,@presid)";
                MySqlCommand comando1 = new MySqlCommand(sql2, conexion);
                comando1.Parameters.Add("@libroid", MySqlDbType.Int16).Value = label18.Text;
                comando1.Parameters.Add("@presid", MySqlDbType.Int16).Value = label17.Text;
                comando1.ExecuteNonQuery();

                string sqlpres = "SELECT PresDet_Id, PresDet_Cantidad, PresEs_Descripcion,stock_id, stock_total FROM prestamodetalle " +
                    "JOIN libro ON Lib_Id = Presdet_Lib_Id " +
                    "JOIN prestamo ON Pres_Id = PresDet_Pres_Id " +
                    "JOIN prestamoestado ON PresEs_id = Pres_PresEs_id " +
                    "JOIN stock ON stock_id = Stock_stock_id " +
                    "WHERE Lib_Titulo = @libro";
                MySqlCommand comandop = new MySqlCommand(sqlpres, conexion);
                comandop.Parameters.Add("@libro", MySqlDbType.VarChar).Value = textLibro.Text;

                MySqlDataReader registrop = comandop.ExecuteReader();
                if (registrop.Read())
                {
                    label21.Text = registrop["stock_id"].ToString();// guardo id stock 22
                    idprestamo = registrop["PresDet_Id"].ToString();// tengo guardado el id del prestamodetalle
                    cantidad = int.Parse(registrop["PresDet_Cantidad"].ToString());//guardo cantidad en entero
                    estadopres = registrop["PresEs_Descripcion"].ToString();// tengo guardado estado prestamo '' en este caso prestado
                    total = int.Parse(registrop["stock_total"].ToString());//guardo total stock
                }
                registrop.Close();


                string sqlres = "UPDATE stock SET stock_cantidad = @cantidad ,stock_total=@total " +
                                "WHERE stock_id=@idstock";
                MySqlCommand comandor = new MySqlCommand(sqlres, conexion);
                comandor.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = 1;
                comandor.Parameters.Add("@total", MySqlDbType.Int32).Value = total - 1;
                comandor.Parameters.Add("@idstock", MySqlDbType.VarChar).Value = label21.Text;
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
               

            }

        }

        //buscar stock disponible
        private bool stockDisponible()
        {
            conexion.Open();
            string sql = "SELECT stock_id,stock_total FROM stock " +
                "JOIN libro ON Stock_stock_id = stock_id " +
                "WHERE Lib_Titulo = @titulo and Lib_LibEs_Id=1";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = textLibro.Text;
            bool existe = false;
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                stockid = int.Parse(registro["stock_id"].ToString());
                total = int.Parse(registro["stock_total"].ToString());
                int cantidad = int.Parse(registro["stock_total"].ToString());
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

        private void Limpiar()
        {
            textDNI.Text = "";
            textNombre.Text = "";
            textApellido.Text = "";
            textLibro.Text = "";
            textAutor.Text = "";
            textEditorial.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label21.Text = "";
            label24.Text = "";
            label23.Text = "";

            idprestamo = "";
            estadopres = "";
            labelDias.Text = "...";
            textBoxnprestamo.Text = "";
            pictureBox1.Image = null;
            buttonEditar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonGrabar.Enabled = true;


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            CalcularDias();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if (textBoxnprestamo.Text == "")
            {
                MessageBox.Show("Debes ingresar N° del prestamo a buscar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxnprestamo.Focus();
                return;

            }
            else
            {
                conexion.Open();
                string sql = "SELECT Pres_Id,Pres_Soc_Id,Pres_Fecha_Entrega,Pres_Fech_Dev,Soc_Nombre,Soc_Apellido,Soc_Dni,Lib_Id,Lib_Titulo,Lib_Img,Aut_Nombre,Edit_Nombre FROM prestamo  " +
                    "JOIN socio ON Soc_Id = Pres_Soc_Id " +
                    "JOIN prestamodetalle ON PresDet_Pres_Id = Pres_Id " +
                    "JOIN libro ON Lib_Id = PresDet_Lib_Id " +
                    "JOIN autor ON Aut_id = Lib_Aut_Id " +
                    "JOIN editorial ON Edit_Id = Lib_Edit_Id " +
                    "WHERE Pres_Id = @prestamoid";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@prestamoid", MySqlDbType.VarChar).Value = textBoxnprestamo.Text;
                MySqlDataReader registros = comando.ExecuteReader();


                bool existe = false;
                while (registros.Read())
                {
                    existe = true;
                    MemoryStream ms = new MemoryStream((byte[])registros["Lib_Img"]);
                    Bitmap bn = new Bitmap(ms);
                    pictureBox1.Image = bn;

                    id_Pres = int.Parse(registros["Pres_Id"].ToString());

                    textDNI.Text = registros["Soc_Dni"].ToString();
                    textNombre.Text = registros["Soc_Nombre"].ToString();
                    textApellido.Text = registros["Soc_Apellido"].ToString();
                    textLibro.Text= registros["Lib_Titulo"].ToString();
                    textAutor.Text = registros["Aut_Nombre"].ToString();
                    textEditorial.Text = registros["Edit_Nombre"].ToString();
                    dateTimePicker1.Value= DateTime.Parse(registros["Pres_Fecha_Entrega"].ToString());
                    dateTimePicker2.Value = DateTime.Parse(registros["Pres_Fech_Dev"].ToString());

                    tituloAux= registros["Lib_Titulo"].ToString();
                   

                }
                conexion.Close();
                if (existe == false)
                {
                    MessageBox.Show("No existe prestamo con ese número ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    buttonEditar.Enabled = false;
                    buttonEliminar.Enabled = false;
                }
                else
                {
                    buttonEditar.Enabled = true;
                    buttonEliminar.Enabled = true;
                    buttonGrabar.Enabled = false;

                }




            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (!stockDisponible())
            {
                MessageBox.Show("No quedan libros en stock , para realizar el prestamo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conexion.Open();
                string sql = "SELECT Lib_Id,Stock_stock_id,stock_total FROM libro " +
                    "JOIN stock ON stock_id=Stock_stock_id " +
                    "WHERE Lib_Titulo=@titulo";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = tituloAux;
                MySqlDataReader registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    id_stockMod = int.Parse(registro["Stock_stock_id"].ToString());
                    id_libMod = int.Parse(registro["Lib_Id"].ToString());
                    stocktotalMod= int.Parse(registro["stock_total"].ToString());
                }
                registro.Close();

                //devuelvo al stock libro que va a intercambiar 
                string sqlres = "UPDATE stock SET stock_cantidad = @cantidad ,stock_total=@total " +
                           "WHERE stock_id=@idstock";
                MySqlCommand comandor = new MySqlCommand(sqlres, conexion);
                comandor.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = 1;
                comandor.Parameters.Add("@total", MySqlDbType.Int32).Value = stocktotalMod + 1;
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
                    label23.Text = registro0["id"].ToString();// tengo guardado el id sesion 17
                }
                registro0.Close();

                string sqlc = "select Ses_Usu_Id FROM sesion " +
                 "WHERE Ses_Id = @idsesion";
                MySqlCommand comando6 = new MySqlCommand(sqlc, conexion);
                comando6.Parameters.Add("@idsesion", MySqlDbType.Int16).Value = label23.Text;
                MySqlDataReader registro6 = comando6.ExecuteReader();
                if (registro6.Read())
                {
                    label24.Text = registro6["Ses_Usu_Id"].ToString();// tengo guardado el id usuario 18
                }
                registro6.Close();

                string sql1 = "UPDATE prestamo SET Pres_Fecha_Entrega=@entrega , Pres_Fech_Dev=@devolucion, Pres_Usu_Id=@usuario " +
                       "WHERE Pres_Id=@idpres";
                MySqlCommand comando2 = new MySqlCommand(sql1, conexion);
                comando2.Parameters.Add("@entrega", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
                comando2.Parameters.Add("@devolucion", MySqlDbType.Date).Value = dateTimePicker2.Value.Date;
                comando2.Parameters.Add("@usuario", MySqlDbType.Int32).Value = label24.Text;
                comando2.Parameters.Add("@idpres", MySqlDbType.Int32).Value = id_Pres;
                int cant0 = comando2.ExecuteNonQuery();

                string sql2 = "UPDATE prestamodetalle SET PresDet_Lib_Id=@idLibro WHERE PresDet_Pres_Id=@presid";
                MySqlCommand comando3 = new MySqlCommand(sql2, conexion);
                comando3.Parameters.Add("@idLibro", MySqlDbType.Int32).Value = libroid;
                comando3.Parameters.Add("@presid", MySqlDbType.Int32).Value = id_Pres;
                int cant1 = comando3.ExecuteNonQuery();



                conexion.Close();

                if (cant1 == 1)
                {

                    MessageBox.Show("El prestamo se actualizó exitosamente!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    desabilitar();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar  los datos del prestamo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                Limpiar();


            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            ValidarPermisos validar = new ValidarPermisos();
            validar.ShowDialog();

            if (validar.existe == true)
            {
                conexion.Open();
                string sqlp = "SELECT Lib_Id,stock_stock_id,stock_total FROM libro " +
                       "JOIN stock ON stock_id=Stock_stock_id " +
                       "WHERE Lib_Titulo=@titulo";
                MySqlCommand comandop = new MySqlCommand(sqlp, conexion);
                comandop.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = tituloAux;
                MySqlDataReader registrop = comandop.ExecuteReader();

                if (registrop.Read())
                {
                    id_stockMod = int.Parse(registrop["Stock_stock_id"].ToString());
                    id_libMod = int.Parse(registrop["Lib_Id"].ToString());
                    stocktotalMod = int.Parse(registrop["stock_total"].ToString());
                }
                registrop.Close();


                //devuelvo a stock el libro antes de eliminar
                string sqlres = "UPDATE stock SET stock_cantidad = @cantidad ,stock_total=@total " +
                               "WHERE stock_id=@idstock";
                MySqlCommand comandor = new MySqlCommand(sqlres, conexion);
                comandor.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = 1;
                comandor.Parameters.Add("@total", MySqlDbType.Int32).Value = stocktotalMod + 1;
                comandor.Parameters.Add("@idstock", MySqlDbType.VarChar).Value = id_stockMod;
                int cant00 = comandor.ExecuteNonQuery();

                string sql = "SELECT PresDet_Id FROM prestamodetalle " +
                    "JOIN prestamo ON Pres_Id = PresDet_Pres_Id " +
                    "JOIN libro ON Lib_Id = PresDet_Lib_Id " +
                    "JOIN socio ON Soc_Id = Pres_Soc_Id " +
                    "WHERE Soc_Dni = @dni AND Lib_Titulo = @titulo";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textDNI.Text;
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
    }
}

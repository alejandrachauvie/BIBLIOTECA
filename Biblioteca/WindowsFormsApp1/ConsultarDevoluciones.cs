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
    public partial class ConsultarDevoluciones : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
        public ConsultarDevoluciones()
        {
            InitializeComponent();
        }

        public void MostrarTable()
        {
            conexion.Open();
            string sql = "SELECT Pres_Id,Pres_Fecha_Entrega,Pres_Fech_Dev,Pres_FechaRealDev,Pres_PresEs_Id,Pres_Soc_Id,Soc_Dni,Soc_Nombre,Soc_Apellido,Soc_Telef,Lib_Id,Lib_Titulo,Aut_Nombre,Edit_Nombre,stock_id,stock_cantidad,stock_total,Usu_Id,Usu_Nombre FROM prestamo  " +
                "JOIN socio ON Soc_Id = Pres_Soc_Id " +
                "JOIN prestamodetalle ON PresDet_Pres_Id = Pres_Id " +
                "JOIN libro ON Lib_Id = PresDet_Lib_Id " +
                "JOIN autor ON Aut_Id = Lib_Aut_Id " +
                "JOIN editorial ON Edit_Id = Lib_Edit_Id " +
                "JOIN stock ON stock_id = Stock_stock_id " +
                "JOIN usuario ON Usu_Id = Pres_Usu_Id " +
                "WHERE Pres_PresEs_Id = 2";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registro = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registro.Read())
            {
              

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
                                    registro["Pres_FechaRealDev"].ToString(),
                                    registro["stock_cantidad"].ToString(),
                                    registro["stock_total"].ToString(),
                                    registro["Usu_Nombre"].ToString());

            }
            registro.Close();
            conexion.Close();


        }

        private void ConsultarDevoluciones_Load(object sender, EventArgs e)
        {
            MostrarTable();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Debes ingresar los datos que quiere buscar. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;

            }
            if (textBox1.Text !="" && radioButton1.Checked)
            {
                conexion.Open();
                string sql = "SELECT Pres_Id,Pres_Fecha_Entrega,Pres_Fech_Dev,Pres_FechaRealDev,Pres_PresEs_Id,Pres_Soc_Id,Soc_Dni,Soc_Nombre,Soc_Apellido,Soc_Telef,Lib_Id,Lib_Titulo,Aut_Nombre,Edit_Nombre,stock_id,stock_cantidad,stock_total,Usu_Id,Usu_Nombre FROM prestamo " +
                    "JOIN socio ON Soc_Id = Pres_Soc_Id " +
                    "JOIN prestamodetalle ON PresDet_Pres_Id = Pres_Id " +
                    "JOIN libro ON Lib_Id = PresDet_Lib_Id " +
                    "JOIN autor ON Aut_Id = Lib_Aut_Id " +
                    "JOIN editorial ON Edit_Id = Lib_Edit_Id " +
                    "JOIN stock ON stock_id = Stock_stock_id " +
                    "JOIN usuario ON Usu_Id = Pres_Usu_Id " +
                    "WHERE Pres_Id = @prestamo";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@prestamo", MySqlDbType.Int32).Value =textBox1.Text;
                MySqlDataReader registro = comando.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (registro.Read())
                {

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
                                        registro["Pres_FechaRealDev"].ToString(),
                                        registro["stock_cantidad"].ToString(),
                                        registro["stock_total"].ToString(),
                                        registro["Usu_Nombre"].ToString());

                }
                registro.Close();
                conexion.Close();
            }
            if(textBox1.Text != "" && radioButton2.Checked)
            {
                conexion.Open();
                string sql= "SELECT Pres_Id,Pres_Fecha_Entrega,Pres_Fech_Dev,Pres_FechaRealDev,Pres_PresEs_Id,Pres_Soc_Id,Soc_Dni,Soc_Nombre,Soc_Apellido,Soc_Telef,Lib_Id,Lib_Titulo,Aut_Nombre,Edit_Nombre,stock_id,stock_cantidad,stock_total,Usu_Id,Usu_Nombre FROM prestamo " +
                    "JOIN socio ON Soc_Id = Pres_Soc_Id " +
                    "JOIN prestamodetalle ON PresDet_Pres_Id = Pres_Id " +
                    "JOIN libro ON Lib_Id = PresDet_Lib_Id " +
                    "JOIN autor ON Aut_Id = Lib_Aut_Id " +
                    "JOIN editorial ON Edit_Id = Lib_Edit_Id " +
                    "JOIN stock ON stock_id = Stock_stock_id " +
                    "JOIN usuario ON Usu_Id = Pres_Usu_Id " +
                    "WHERE Soc_Dni = @dni AND Pres_PresEs_Id = 2";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textBox1.Text;
                MySqlDataReader registro = comando.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (registro.Read())
                {

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
                                        registro["Pres_FechaRealDev"].ToString(),
                                        registro["stock_cantidad"].ToString(),
                                        registro["stock_total"].ToString(),
                                        registro["Usu_Nombre"].ToString());

                }
                registro.Close();
                conexion.Close();
            }
            if (textBox1.Text != "" && radioButton3.Checked)
            {
                conexion.Open();
                string sql = "SELECT Pres_Id,Pres_Fecha_Entrega,Pres_Fech_Dev,Pres_FechaRealDev,Pres_PresEs_Id,Pres_Soc_Id,Soc_Dni,Soc_Nombre,Soc_Apellido,Soc_Telef,Lib_Id,Lib_Titulo,Aut_Nombre,Edit_Nombre,stock_id,stock_cantidad,stock_total,Usu_Id,Usu_Nombre FROM prestamo " +
                    "JOIN socio ON Soc_Id = Pres_Soc_Id " +
                    "JOIN prestamodetalle ON PresDet_Pres_Id = Pres_Id " +
                    "JOIN libro ON Lib_Id = PresDet_Lib_Id " +
                    "JOIN autor ON Aut_Id = Lib_Aut_Id " +
                    "JOIN editorial ON Edit_Id = Lib_Edit_Id " +
                    "JOIN stock ON stock_id = Stock_stock_id " +
                    "JOIN usuario ON Usu_Id = Pres_Usu_Id " +
                    "WHERE Lib_Titulo = @titulo AND Pres_PresEs_Id = 2";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = textBox1.Text;
                MySqlDataReader registro = comando.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (registro.Read())
                {

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
                                        registro["Pres_FechaRealDev"].ToString(),
                                        registro["stock_cantidad"].ToString(),
                                        registro["stock_total"].ToString(),
                                        registro["Usu_Nombre"].ToString());

                }
                registro.Close();
                conexion.Close();

            }
        }

        private void buttonporfechas_Click(object sender, EventArgs e)
        {
           
                conexion.Open();
                string sql = "SELECT Pres_Id,Pres_Fecha_Entrega,Pres_Fech_Dev,Pres_FechaRealDev,Pres_PresEs_Id,Pres_Soc_Id,Soc_Dni,Soc_Nombre,Soc_Apellido,Soc_Telef,Lib_Id,Lib_Titulo,Aut_Nombre,Edit_Nombre,stock_id,stock_cantidad,stock_total,Usu_Id,Usu_Nombre FROM prestamo " +
                "JOIN socio ON Soc_Id = Pres_Soc_Id " +
                "JOIN prestamodetalle ON PresDet_Pres_Id = Pres_Id " +
                "JOIN libro ON Lib_Id = PresDet_Lib_Id " +
                "JOIN autor ON Aut_Id = Lib_Aut_Id " +
                "JOIN editorial ON Edit_Id = Lib_Edit_Id " +
                "JOIN stock ON stock_id = Stock_stock_id " +
                "JOIN usuario ON Usu_Id = Pres_Usu_Id " +
                "WHERE Pres_FechaRealDev > @fechainicial AND Pres_FechaRealDev< @fechafin";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@fechainicial", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
               comando.Parameters.Add("@fechafin", MySqlDbType.Date).Value = dateTimePicker2.Value.Date;
                MySqlDataReader registro = comando.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (registro.Read())
                {

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
                                        registro["Pres_FechaRealDev"].ToString(),
                                        registro["stock_cantidad"].ToString(),
                                        registro["stock_total"].ToString(),
                                        registro["Usu_Nombre"].ToString());

                }
                registro.Close();
                conexion.Close();

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

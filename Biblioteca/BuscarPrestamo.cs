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
    public partial class BuscarPrestamo : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
        public BuscarPrestamo()
        {
            InitializeComponent();
            autoCompletar();
        }

        DataTable datos = new DataTable();
        void autoCompletar()
        {
            string sql = "SELECT Lib_Titulo FROM libro";
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexion);
            adaptador.Fill(datos);

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i]["Lib_Titulo"].ToString());

            }

            textBoxBuscar.AutoCompleteCustomSource = lista;
        }


        public void MostrarTabla()
        {
            conexion.Open();
            string sql = "SELECT Pres_Id,Pres_Fecha_Entrega,Pres_Fech_Dev,Pres_PresEs_Id,Pres_Soc_Id,Soc_Dni,Soc_Nombre,Soc_Apellido,Soc_Telef,Lib_Id,Lib_Titulo,Aut_Nombre,Edit_Nombre,stock_id,stock_cantidad,Usu_Id,Usu_Nombre FROM prestamo    " +
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
               

                dataGridView1.Rows.Add(registro["Pres_Id"].ToString(),
                                    registro["Lib_Titulo"].ToString(),
                                     registro["Aut_Nombre"].ToString(),
                                    registro["Edit_Nombre"].ToString(),
                                    registro["stock_cantidad"].ToString(),
                                    registro["Soc_Dni"].ToString(),
                                    registro["Soc_Apellido"].ToString(),
                                    registro["Soc_Nombre"].ToString(),
                                    registro["Pres_Fecha_Entrega"].ToString(),
                                    registro["Pres_Fech_Dev"].ToString(), 
                                    registro["Usu_Nombre"].ToString());

            }
            registro.Close();
            conexion.Close();



        }


        private void buttonbuscar_Click(object sender, EventArgs e)
        {

        }

        private void BuscarPrestamo_Load(object sender, EventArgs e)
        {
            MostrarTabla();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

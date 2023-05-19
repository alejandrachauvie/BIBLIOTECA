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
    public partial class BuscarLibro : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
        public BuscarLibro()
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

            for(int i=0; i< datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i]["Lib_Titulo"].ToString());

            }

            textBoxBuscar.AutoCompleteCustomSource = lista;
        }
       

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            if (textBoxBuscar.Text == "")
            {
                MessageBox.Show("Debe ingresar Titulo del libro para realizar consulta", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBuscar.Focus();
                return;
            }
            else
            {
                conexion.Open();
                string sql = "SELECT Lib_Titulo,Lib_Id,Lib_cantHojas,Lib_Descripcion,LibEs_Descripcion,Aut_Nombre,Edit_Nombre,Ubic_Descripcion,Esta_Descripcion,stock_Total FROM libro  " +
                    "JOIN autor ON Aut_id = Lib_Aut_id " +
                    "JOIN editorial ON Edit_id = Lib_Edit_id " +
                    "JOIN stock ON stock_id = stock_stock_id " +
                    "JOIN libroestado ON LibEs_Id = Lib_LibEs_Id " +
                    "JOIN estante ON Esta_id = Lib_Esta_id " +
                    "JOIN ubicacion ON Ubic_id = Esta_Ubic_id " +
                    "WHERE Lib_Titulo LIKE @titulo";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = textBoxBuscar.Text;
                MySqlDataReader registros = comando.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (registros.Read())
                {
                    dataGridView1.Rows.Add(registros["Lib_Titulo"].ToString(),
                                           registros["Lib_Id"].ToString(),
                                           registros["Lib_cantHojas"].ToString(),
                                           registros["Lib_Descripcion"].ToString(),
                                            registros["LibEs_Descripcion"].ToString(),
                                            registros["Aut_Nombre"].ToString(),
                                           registros["Edit_Nombre"].ToString(),
                                            registros["Ubic_Descripcion"].ToString(),
                                             registros["Esta_Descripcion"].ToString(),
                                           registros["stock_Total"].ToString());
                                           

                }
                registros.Close();
                conexion.Close();
                    



            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        public void MostrarTabla()
        {
            conexion.Open();
            string sql = "SELECT Lib_Id,Lib_Titulo,Lib_cantHojas,Lib_Descripcion,LibEs_Descripcion,Aut_Nombre,Edit_Nombre,Ubic_Descripcion,stock_total FROM libro " +
                "JOIN libroestado ON LibEs_id = Lib_LibEs_id " +
                "JOIN autor ON Aut_id = Lib_Aut_id " +
                "JOIN editorial ON Edit_id = Lib_Edit_id " +
                "JOIN estante ON Esta_id = Lib_Esta_id " +
                "JOIN ubicacion ON Ubic_id = Esta_Ubic_id " +
                "JOIN stock ON stock_id = stock_stock_id " +
                "ORDER BY Lib_Titulo";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["Lib_Titulo"].ToString(),
                                       registros["Lib_Id"].ToString(),
                                       registros["Lib_cantHojas"].ToString(),
                                       registros["Lib_Descripcion"].ToString(),
                                       registros["LibEs_Descripcion"].ToString(),
                                        registros["Aut_Nombre"].ToString(),
                                       registros["Edit_Nombre"].ToString(),
                                       registros["Ubic_Descripcion"].ToString(),
                                        registros["stock_total"].ToString());

            }
            registros.Close();
            conexion.Close();



        }

        private void BuscarLibro_Load(object sender, EventArgs e)
        {
            MostrarTabla();
        }
    }
}

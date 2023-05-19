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
    public partial class BuscarSocio : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
        public BuscarSocio()
        {
            InitializeComponent();
            autoCompletar();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        DataTable datos = new DataTable();
        void autoCompletar()
        {
            string sql = "SELECT Soc_Apellido FROM socio";
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexion);
            adaptador.Fill(datos);

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i]["Soc_Apellido"].ToString());

            }

            textBoxBuscar.AutoCompleteCustomSource = lista;
        }


        public void MostrarTabla()
        {
            conexion.Open();
            string sql = "SELECT Soc_Nombre,Soc_Apellido,Soc_Dni,Soc_Telef,SocEs_Descripcion,Dom_Calle,Dom_Numero,Dom_piso,Dom_Apto,Local_Nombre,Prov_Nombre,Pais_Nombre,InscDet_Monto,InscEs_Descripcion FROM socio  " +
                "JOIN domicilio ON Dom_Id = Soc_Dom_Id " +
                "JOIN localidad ON Local_Id = Dom_Local_Id " +
                "JOIN provincia ON Prov_Id = Local_Prov_Id " +
                "JOIN pais ON Pais_Id = Prov_Pais_Id " +
                "JOIN socioestado ON SocEs_Id = Soc_SocEs_Id " +
                "JOIN inscripcion ON Insc_Id " +
                "JOIN inscripciondetalle ON InscDet_Soc_Id = Soc_Id AND InscDet_Insc_Id = Insc_Id " +
                "JOIN inscripcionestado ON InscEs_Id = Insc_InscEs_Id " +
                "ORDER BY Soc_Apellido";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(
                                        registros["Soc_Apellido"].ToString(),
                                        registros["Soc_Nombre"].ToString(),
                                        registros["Soc_Dni"].ToString(),
                                        registros["Soc_Telef"].ToString(),
                                        registros["Dom_Calle"].ToString(),
                                        registros["Dom_Numero"].ToString(),
                                        registros["Dom_piso"].ToString(),
                                        registros["Dom_Apto"].ToString(), 
                                        registros["Local_Nombre"].ToString(),
                                        registros["Prov_Nombre"].ToString(),
                                        registros["Pais_Nombre"].ToString(),
                                        registros["InscDet_Monto"].ToString(),
                                        registros["InscEs_Descripcion"].ToString());
            }
            registros.Close();
            conexion.Close();


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
                string sql = "SELECT InscEs_Id, Insc_Id ,InscDet_Monto,Soc_Nombre,Soc_Apellido,Soc_Dni,Soc_Telef,SocEs_descripcion,Dom_Calle,Dom_Numero,Dom_piso,Dom_Apto,Local_Nombre,Prov_Nombre,Pais_Nombre,InscEs_Descripcion FROM socio " +
                    "JOIN domicilio ON Dom_Id = Soc_Dom_Id " +
                    "JOIN localidad ON Local_Id = Dom_Local_Id " +
                    "JOIN socioestado ON SocEs_Id = Soc_SocEs_Id " +
                    "JOIN provincia ON Prov_Id = Local_Prov_Id " +
                    "JOIN pais ON Pais_Id = Prov_Pais_Id " +
                    "JOIN inscripciondetalle ON Soc_Id = InscDet_Soc_Id " +
                    "JOIN inscripcion ON Insc_Id = InscDet_Insc_Id " +
                    "JOIN inscripcionestado ON InscEs_Id = Insc_InscEs_Id " +
                    "WHERE Soc_Apellido = @apellido  ";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@apellido", MySqlDbType.VarChar).Value = textBoxBuscar.Text;
                MySqlDataReader registros = comando.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (registros.Read())
                {
                    dataGridView1.Rows.Add(registros["Soc_Apellido"].ToString(),
                                           registros["Soc_Nombre"].ToString(),
                                           registros["Soc_Dni"].ToString(),
                                           registros["Soc_Telef"].ToString(),
                                            registros["Dom_Calle"].ToString(),
                                           registros["Dom_Numero"].ToString(),
                                           registros["Dom_piso"].ToString(),
                                            registros["Dom_Apto"].ToString(),
                                           registros["Local_Nombre"].ToString(),
                                           registros["Prov_Nombre"].ToString(),
                                           registros["Pais_Nombre"].ToString(),
                                           registros["InscDet_Monto"].ToString(),
                                            registros["InscEs_Descripcion"].ToString() ); 


                }
                registros.Close();
                conexion.Close();

            }
        }

        private void BuscarSocio_Load(object sender, EventArgs e)
        {
            MostrarTabla();
        }
    }
}

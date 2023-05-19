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
    
    public partial class CargarLocalidadescs : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");

        public CargarLocalidadescs()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ExisteLocalidad()
        {
            conexion.Open();
            string sql = "SELECT Local_id FROM localidad where Local_Nombre= @localidad";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@localidad", MySqlDbType.VarChar).Value = textLocalidad.Text;
            MySqlDataReader registro1 = comando.ExecuteReader();
            bool existe = false;
            if (registro1.Read())
            {
                existe = true;


            }
            conexion.Close();
            return existe;
        }

        private bool ExisteProvincia()
        {
            conexion.Open();
            string sql = "SELECT Prov_Id FROM provincia where Prov_Nombre=@provincia";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@provincia", MySqlDbType.VarChar).Value = textProvincia.Text;
            MySqlDataReader registro1 = comando.ExecuteReader();
            bool existe = false;
            if (registro1.Read())
            {
                existe = true;


            }
            conexion.Close();
            return existe;
        }

        private void buttonGrabarLocalidad_Click(object sender, EventArgs e)
        {
            if (ExisteLocalidad())
            {
                MessageBox.Show("Ya existe esa Localidad ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textLocalidad.Focus();
                return;
            }
            else
            {
                conexion.Open();
                string sql = "INSERT INTO localidad (Local_Nombre,Local_Prov_Id) VALUES (@localidad,@provincia)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@localidad", MySqlDbType.VarChar).Value = textLocalidad.Text;
                comando.Parameters.Add("@provincia", MySqlDbType.Int16).Value = comboProv.SelectedValue.ToString();
                comando.ExecuteNonQuery();

            }
            conexion.Close();
            textLocalidad.Text = "";
            MessageBox.Show("Los datos fueron guardados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CargarPais()
        {
            conexion.Open();
            string sql = "select Pais_Id,Pais_Nombre from pais";
            MySqlDataAdapter adaptador1 = new MySqlDataAdapter();

            adaptador1.SelectCommand = new MySqlCommand(sql, conexion);

            DataTable tabla = new DataTable();
            adaptador1.Fill(tabla);
            tabla.Rows.Add(0, "Selecciona País");
            tabla.DefaultView.Sort = "Pais_id";
            comboPais.DataSource = tabla;
            comboPais.DisplayMember = "Pais_Nombre";
            comboPais.ValueMember = "Pais_id";
            conexion.Close();
        }



        public void CargarProvincia()
        {
            conexion.Open();
            string sql = "select Prov_Id,Prov_Nombre from provincia";
            MySqlDataAdapter adaptador1 = new MySqlDataAdapter();
            adaptador1.SelectCommand = new MySqlCommand(sql, conexion);

            DataTable tabla = new DataTable();
            adaptador1.Fill(tabla);
            tabla.Rows.Add(0, "Selecciona Provincia");
            tabla.DefaultView.Sort = "Prov_id";
            comboProv.DataSource = tabla;
            comboProv.DisplayMember = "Prov_Nombre";
            comboProv.ValueMember = "Prov_id";

            conexion.Close();

        }

        private void CargarLocalidadescs_Load(object sender, EventArgs e)
        {
            CargarPais();
            CargarProvincia();
        }

        private void buttonGrabarProvincia_Click(object sender, EventArgs e)
        {
            if (ExisteProvincia())
            {
                MessageBox.Show("Ya existe la Provincia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textProvincia.Focus();
                return;
            }
            else
            {
                conexion.Open();
                string sql = "INSERT INTO provincia (Prov_Nombre,Prov_Pais_Id) VALUES (@provincia,@pais)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@provincia", MySqlDbType.VarChar).Value = textProvincia.Text;
                comando.Parameters.Add("@pais", MySqlDbType.Int16).Value = comboPais.SelectedValue.ToString();
                comando.ExecuteNonQuery();

            }
            conexion.Close();
            textLocalidad.Text = "";
            MessageBox.Show("Los datos fueron guardados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

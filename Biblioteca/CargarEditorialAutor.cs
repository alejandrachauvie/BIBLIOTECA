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
   
    public partial class CargarEditorialAutor : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
        public CargarEditorialAutor()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonGrabar_Click(object sender, EventArgs e)
        {
            if (ExisteAutor())
            {
                MessageBox.Show("Ya existe el Autor ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNomAut.Focus();
                return;
            }
            else
            {
                conexion.Open();
                string sql = "INSERT INTO autor (Aut_Nombre) VALUES (@autor)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@autor", MySqlDbType.VarChar).Value = textNomAut.Text;
                comando.ExecuteNonQuery();

            }
            conexion.Close();
            textNomAut.Text = "";
            MessageBox.Show("Los datos fueron guardados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ExisteAutor()
        {
            conexion.Open();
            string sql = "SELECT Aut_id FROM autor where Aut_Nombre=@autor";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@autor", MySqlDbType.VarChar).Value = textNomAut.Text;
            MySqlDataReader registro1 = comando.ExecuteReader();
            bool existe = false;
            if (registro1.Read())
            {
                existe = true;


            }
            conexion.Close();
            return existe;
        }

        private void buttonGrabarEditorial_Click(object sender, EventArgs e)
        {
            if (ExisteEditorial())
            {
                MessageBox.Show("Ya existe la Editorial ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textEdit.Focus();
                return;
            }
            else
            {
                conexion.Open();
                string sql = "INSERT INTO editorial (Edit_Nombre) VALUES (@editorial)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@editorial", MySqlDbType.VarChar).Value = textEdit.Text;
                comando.ExecuteNonQuery();


            }
            conexion.Close();
            textEdit.Text = "";
            MessageBox.Show("Los datos fueron guardados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ExisteEditorial()
        {
            conexion.Open();
            string sql = "SELECT Edit_id FROM editorial where Edit_Nombre= @editorial";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@editorial", MySqlDbType.VarChar).Value = textEdit.Text;
            MySqlDataReader registro1 = comando.ExecuteReader();
            bool existe = false;
            if (registro1.Read())
            {
                existe = true;


            }
            conexion.Close();
            return existe;
        }
    }
}

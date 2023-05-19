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
    public partial class ValidarPermisos : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
        public bool existe;
        public ValidarPermisos()
        {
            InitializeComponent();
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = "SELECT Usu_Id,Usu_Nombre,Usu_Apellido,Usu_Usuario FROM usuario " +
                "WHERE Usu_Tipo=@tipo AND Usu_Clave=@clave";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = textBox1.Text;
            comando.Parameters.Add("@clave", MySqlDbType.VarChar).Value = textBox2.Text;
            MySqlDataReader registro = comando.ExecuteReader();

             existe = false;
            if (registro.Read())
            {
                existe = true;
                label3.Text = registro["Usu_Id"].ToString();// tengo guardado el id del usuario
                Clases.VariableUsuario.usuarioNombre = registro["Usu_Nombre"].ToString();
                Clases.VariableUsuario.UsuarioApellido = registro["Usu_Apellido"].ToString();
                registro.Close();

                this.Hide();//cierro pantalla login
              

                return;

            }
            else
            {
               
                MessageBox.Show("No es un Usuario autorizado para seguir con el procedimiento!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            conexion.Close();
            

        }
    }
}

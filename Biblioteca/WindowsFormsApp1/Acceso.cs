using MySql.Data.MySqlClient;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using MessageBox = System.Windows.Forms.MessageBox;

namespace WindowsFormsApp1
{
    public partial class Acceso : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
        public Acceso()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 195)
            {
                MenuVertical.Width = 49;
            }
            else
            {
                MenuVertical.Width = 195;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Desea cerrar sesion ?", "Cerrar", (MessageBoxButton)MessageBoxButtons.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                CerrarSesion();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       /* private void horafecha_Tick(object sender, EventArgs e)
        {
            labelhora.Text = DateTime.Now.ToString("HH:mm:ss");
            labelfecha.Text = DateTime.Now.ToLongDateString();
        }*/

        private void Acceso_Load(object sender, EventArgs e)
        {
            label2.Text = Clases.VariableUsuario.usuarioNombre + " " + Clases.VariableUsuario.UsuarioApellido;
            pictureBox2_Click(null, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormulario(object formulario)
        {
            if (this.panel1.Controls.Count>0)
            
                this.panel1.Controls.RemoveAt(0);
            Form fh = formulario as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
            
        }

        private void socio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Socios());
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new PantPrincipal());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new libros());
        }

        private void CerrarSesion()
        {
            conexion.Open();
            string sql = "SELECT  MAX(Ses_Id ) AS 'id' FROM sesion";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                label3.Text = registro["id"].ToString();
            }
            registro.Close();

            string sql5 = "UPDATE sesion SET Ses_Fech_Fin= NOW()  WHERE Ses_Id = @id";
            MySqlCommand comando5 = new MySqlCommand(sql5, conexion);
            comando5.Parameters.Add("@id", MySqlDbType.VarChar).Value = label3.Text;
            int cant= comando5.ExecuteNonQuery();
            conexion.Close();
            label3.Text = "";

            this.Close();
            Login log = new Login();
            log.Show();
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Desea Cerrar Sesion?", "Eliminar", MessageBoxButtons.YesNo);
            if (dr== DialogResult.Yes)
            {
                CerrarSesion();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Prestamo());
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            panelsubmenu.Visible = true;
        }

        private void buttonrepPres_Click(object sender, EventArgs e)
        {
            panelsubmenu.Visible=false;
            AbrirFormulario(new ReportePrestamos());
        }

        private void buttonrepDev_Click(object sender, EventArgs e)
        {
            panelsubmenu.Visible = false;
            AbrirFormulario(new ReportesDevoluciones());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Cuotas());
        }
    }

    
}

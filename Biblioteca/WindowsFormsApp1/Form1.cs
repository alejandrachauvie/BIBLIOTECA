using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
    public partial class Login : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
        private int borderRadius = 30;
        private int borderSize = 2;
        private Color borderColor = Color.Blue;

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
         private extern static void SendMessage(System.IntPtr hWnd,int wMsg, int wParam, int lParam);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000;
                return cp;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private GraphicsPath GetRoundedPath(Rectangle rect,float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;

        }

        private void FormRegionAndBorder(Form form,float radius ,Graphics graph,Color borderColor,float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void DrawPath(Rectangle rect,Graphics graph,Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius)) 
            using (Pen penBorder= new Pen(color, 2))
            {
                graph.DrawPath(penBorder,roundPath);


            }
        }
     

        private void Login_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe ingresar Usuario para poder continuar");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Debe ingresar Clave para poder continuar");
                textBox2.Focus();
                return;
            }

            else
            {
                conexion.Open();
                String sql = "select Usu_Id,Usu_Nombre,Usu_Apellido,Usu_Usuario,Usu_Clave,UsuEs_Descripcion from usuario " +
                    "JOIN usuarioestado ON Usu_UsuEs_id = Usu_UsuEs_id " +
                    "where Usu_Usuario = @Usu_Usuario and Usu_Clave = @Usu_Clave AND Usu_UsuEs_id = 1 ";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@Usu_Usuario", MySqlDbType.VarChar).Value = textBox1.Text;
                comando.Parameters.Add("@Usu_Clave", MySqlDbType.VarChar).Value = textBox2.Text;
                MySqlDataReader registro = comando.ExecuteReader();


                bool existe = false;
                if (registro.Read())
                {
                    existe = true;
                    label4.Text = registro["Usu_Id"].ToString();// tengo guardado el id del usuario
                    Clases.VariableUsuario.usuarioNombre = registro["Usu_Nombre"].ToString();
                    Clases.VariableUsuario.UsuarioApellido = registro["Usu_Apellido"].ToString();
                    registro.Close();
                    String sql1 = "INSERT INTO sesion(Ses_Fech_Inic,Ses_Fech_Fin,Ses_SesEs_Id,Ses_Usu_Id) VALUES (NOW(),NULL ,1,@usuarioid)";
                    MySqlCommand comando1 = new MySqlCommand(sql1, conexion);
                    comando1.Parameters.Add("@usuarioid", MySqlDbType.Int16).Value = label4.Text;
                    comando1.ExecuteNonQuery();

                    this.Hide();//cierro pantalla login
                    CargarPantalla cargar = new CargarPantalla();
                    cargar.ShowDialog();

                    Acceso m = new Acceso();
                    m.Show();
                   
                    return;

                }
                else
                {

                    MessageBox.Show("No existe el Usuario o contraseña ingresado","Atencion",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                conexion.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
    }
}

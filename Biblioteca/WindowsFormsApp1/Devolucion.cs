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
    public partial class Devolucion : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
       
        public Devolucion()
        {
            InitializeComponent();
        }

        private void Devolucion_Load(object sender, EventArgs e)
        {
            textPrestamo.Enabled = false;
            TBDni.Enabled = false;
            dtfechDev.Enabled = false;
            textLibro.Enabled = false;
           
        }

        public bool FechaHoyoAnterior()
        {
            DateTime hoy = DateTime.Today;
            if (dateTimePicker2.Value.Date == hoy)
            {
                return false;
            }
            return true;
        }

    

        private void BDevolver_Click(object sender, EventArgs e)
        {
          
            if (FechaHoyoAnterior())
            {

                MessageBox.Show("Fecha Invalida, No puedes seleccionar una fecha posterior y/o anterior para su devolucion, debes ingresar la fecha de hoy", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker2.Focus();
                return;

            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Debes ingresar comentarios. ");
                textBox2.Focus();
                return;
            }
            else
            {
                conexion.Open();
                string sql = "UPDATE prestamo SET pres_comentarios=@comentarios ," +
                    "Pres_FechaRealDev=@fechreal, Pres_PresEs_Id=2 WHERE Pres_Id =@idpres";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@fechreal", MySqlDbType.Date).Value = dateTimePicker2.Value.Date; 
                comando.Parameters.Add("@comentarios", MySqlDbType.VarChar).Value = textBox2.Text;
                comando.Parameters.Add("@idpres", MySqlDbType.Int32).Value = textPrestamo.Text;
                int cant = comando.ExecuteNonQuery();

                //devolver al stock el libro prestado
                string sqlres = "UPDATE stock SET stock_total=@total " +
                               "WHERE stock_id=@idstock";
                MySqlCommand comandor = new MySqlCommand(sqlres, conexion);
                comandor.Parameters.Add("@idstock", MySqlDbType.Int32).Value = labelStock.Text;
                comandor.Parameters.Add("@total", MySqlDbType.Int32).Value = labeltotal.Text;
                int cant00 = comandor.ExecuteNonQuery();


                if (cant00 == 1)
                {

                    MessageBox.Show("La devolucion se registro Correctamente!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("No se pudo registrar la devolución.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                                                     

                conexion.Close();
                Limpiar();
            }
            this.Hide();

        }

        private void Limpiar()
        {
            textPrestamo.Text = "";
            TBDni.Text = "";
            textLibro.Text = "";
            textBox2.Text = "";

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

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
    public partial class PresentacionPrestamo : Form
    {
        public PresentacionPrestamo()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CargarPrestamo cargaPrestamo = new CargarPrestamo();
            cargaPrestamo.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           BuscarPrestamo buscarPrestamo = new BuscarPrestamo();
            buscarPrestamo.Show();
        }
    }
}

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
    public partial class LibrosPresentacion : Form
    {
        public LibrosPresentacion()
        {
            InitializeComponent();
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CargarLibros cargarLibro = new CargarLibros();
            cargarLibro.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CargarEditorialAutor cargareditaut = new CargarEditorialAutor();
            cargareditaut.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BuscarLibro buscarLibro = new BuscarLibro();
            buscarLibro.Show();
        }
    }
}

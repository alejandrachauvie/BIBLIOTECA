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
    public partial class SociosPresentacion : Form
    {
        public SociosPresentacion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CargarSocio cargarSocios = new CargarSocio();
            cargarSocios.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BuscarSocio buscarSocio = new BuscarSocio();
            buscarSocio.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CargarLocalidadescs cargarLocalidades = new CargarLocalidadescs();
            cargarLocalidades.Show();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class ReporteMorosos : Form
    {
        int cuotasvencidas;
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
        public ReporteMorosos()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        ArrayList Mes = new ArrayList();
        ArrayList Cant = new ArrayList();

        public void CuotasVencidas()
        {
            conexion.Open();
            string sql = "SELECT Cuo_Mes AS 'Mes' ,COUNT(Cuo_Id) AS 'Cant' FROM cuota " +
                "WHERE Cuo_CuoEs_Id = 2 " +
                "GROUP BY Cuo_Mes";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                Mes.Add(registro.GetString(0));
                Cant.Add(registro.GetInt32(1));
            }
            chartMorosos.Series[0].Points.DataBindXY(Mes, Cant);
            registro.Close();
            conexion.Close();

        }

        public void CantVencidas()
        {
            conexion.Open();
            string sql = "SELECT COUNT(Cuo_Id) AS 'Cant' FROM cuota " +
                "WHERE Cuo_CuoEs_Id = 2";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                labelcvencidas.Text=registro["Cant"].ToString();
               // labelTotPres.Text = registro["Total"].ToString();// cantidad prestamos vigentes
            }
            registro.Close();


            conexion.Close();
        }

        public void CuotasXVencer()
        {
            conexion.Open();
            string sql = "SELECT COUNT(Cuo_Id) AS 'Cant' FROM cuota " +
                "WHERE Cuo_Fecha_Pago >= '2022-12-01' AND Cuo_Fecha_Pago <= '2022-12-31' AND Cuo_CuoEs_Id = 1";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                labelcvencidas.Text = registro["Cant"].ToString();
               
            }
            registro.Close();


            conexion.Close();
        }

        private void ReporteMorosos_Load(object sender, EventArgs e)
        {
            CuotasVencidas();
            CantVencidas();
        }
    }
}

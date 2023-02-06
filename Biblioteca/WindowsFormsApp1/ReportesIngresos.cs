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
   
    public partial class ReportesIngresos : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
        public ReportesIngresos()
        {
            InitializeComponent();
           
        }
        ArrayList Socio = new ArrayList();
        ArrayList Cant = new ArrayList();

        public void Grafico()
        {
            conexion.Open();
            string sql = "SELECT Soc_Apellido AS 'Socios', sum(CuoDet_Monto) AS 'Monto' FROM cuotadetalle " +
                "JOIN cuota ON Cuo_Id = CuoDet_Cuo_Id " +
                "JOIN socio ON Soc_Id = CuoDet_Soc_Id " +
                "WHERE Cuo_Fecha_Pago = @fpago " +
                "GROUP BY Soc_Apellido";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@fpago", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
            MySqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
               
                    Socio.Add(registro.GetString(0));
                    Cant.Add(registro.GetInt32(1));
               
            }
           chart1.Series[0].Points.DataBindXY(Socio, Cant);
            registro.Close();
            conexion.Close();

        }

        ArrayList Socio2 = new ArrayList();
        ArrayList Cant2 = new ArrayList();

        public void Grafico1()
        {
            DateTime hoy = DateTime.Today;
            conexion.Open();
            string sql = "SELECT Soc_Apellido AS 'Socios', sum(CuoDet_Monto) AS 'Monto' FROM cuotadetalle  " +
                "JOIN socio ON Soc_Id = CuoDet_Soc_Id " +
                "JOIN cuota ON Cuo_Id = CuoDet_Cuo_Id " +
                "WHERE Cuo_Fecha_Pago = '2022-12-06' " +
                "GROUP BY Soc_Apellido";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {

                Socio2.Add(registro.GetString(0));
                Cant2.Add(registro.GetInt32(1));

            }
            chart1.Series[0].Points.DataBindXY(Socio2, Cant2);
            registro.Close();
            conexion.Close();
           

        }

        public void Resultado()
        {
            conexion.Open();
            string sql = " SELECT  count(Soc_Apellido) AS 'Socio' ,sum(CuoDet_Monto) AS 'Monto' FROM cuotadetalle  " +
                "JOIN socio ON Soc_Id = CuoDet_Soc_Id " +
                "JOIN cuota ON Cuo_Id = CuoDet_Cuo_Id " +
                "WHERE Cuo_Fecha_Pago = '2022-12-06' ";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {

                labelMonto.Text = registro["Monto"].ToString();

            }
           
            registro.Close();
            conexion.Close();


        }
    



        private void buttonConsultar_Click(object sender, EventArgs e)
        {
           Grafico();
        }


        ArrayList Socio1 = new ArrayList();
        ArrayList Cant1 = new ArrayList();
        public void GraficoGeneral()
        {
            conexion.Open();
            string sql = "SELECT Soc_Apellido AS 'Socios', sum(CuoDet_Monto) AS 'Monto' FROM cuotadetalle " +
                "JOIN cuota ON Cuo_Id = CuoDet_Cuo_Id " +
                "JOIN socio ON Soc_Id = CuoDet_Soc_Id " +
                "GROUP BY Soc_Apellido " +
                "ORDER BY Soc_Apellido ";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                Socio1.Add(registro.GetString(0));
                Cant1.Add(registro.GetInt32(1));
            }
            chartIngresos.Series[0].Points.DataBindXY(Socio1, Cant1);
            registro.Close();
            conexion.Close();

        }

        private void ReportesIngresos_Load(object sender, EventArgs e)
        {
            GraficoGeneral();
            Grafico1();
            Resultado();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

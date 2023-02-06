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
    public partial class ReportesDevoluciones : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
        string cantidad;
        string cantidad1;
        public ReportesDevoluciones()
        {
            InitializeComponent();
        }

        private void ReportesDevoluciones_Load(object sender, EventArgs e)
        {
            GraficoLibrosDev();
            GraficoDevRetrazos();
            CargarCantDev();
            CargarDevRetrazo();

        }
        public void CargarDevRetrazo()
        {
            conexion.Open();
            string sql1 = "SELECT Lib_Titulo AS 'Título', sum(PresDet_Cantidad) AS 'Cantidad' FROM libro   " +
               "JOIN prestamodetalle ON Lib_Id = PresDet_Lib_Id " +
               "JOIN stock ON stock_id = Stock_stock_id " +
               "JOIN prestamo ON Pres_Id = PresDet_Pres_Id " +
               "WHERE Pres_PresEs_Id = 2  AND Pres_Fech_Dev<Pres_FechaRealDev ";
            MySqlCommand comando1 = new MySqlCommand(sql1, conexion);
            MySqlDataReader registro1 = comando1.ExecuteReader();
            if (registro1.Read())
            {

                cantidad1 = registro1["Cantidad"].ToString();
                labelVencidos.Text = cantidad1.ToString();

            }



            registro1.Close();
            conexion.Close();

        }

        public void CargarCantDev()
        {
            conexion.Open();
            string sql = "SELECT Lib_Titulo AS 'Título', sum(PresDet_Cantidad) AS 'Cantidad' FROM libro  " +
                "JOIN prestamodetalle ON Lib_Id = PresDet_Lib_Id " +
                "JOIN stock ON stock_id = Stock_stock_id " +
                "JOIN prestamo ON Pres_Id = PresDet_Pres_Id " +
                "WHERE Pres_PresEs_Id = 2 ";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@fecha1", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
            comando.Parameters.Add("@fecha2", MySqlDbType.Date).Value = dateTimePicker2.Value.Date;
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {

                cantidad = registro["Cantidad"].ToString();
                label4.Text = cantidad.ToString();

            }



            registro.Close();
            conexion.Close();
        }

        ArrayList Libro = new ArrayList();
        ArrayList Cant = new ArrayList();
      

        private void GraficoLibrosDev()
        {
            conexion.Open();
            string sql = "SELECT Lib_Titulo AS 'Título', sum(PresDet_Cantidad) AS 'Cantidad', stock_total AS 'stock actual' FROM libro  " +
                "JOIN prestamodetalle ON Lib_Id = PresDet_Lib_Id " +
                "JOIN stock ON stock_id = Stock_stock_id " +
                "JOIN prestamo ON Pres_Id = PresDet_Pres_Id " +
                "WHERE Pres_PresEs_Id = 2 " +
                "GROUP BY Lib_Titulo " +
                "ORDER BY Lib_Titulo";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                Libro.Add(registro.GetString(0));
                Cant.Add(registro.GetInt32(1));
              
            }
            chartRepDev.Series[0].Points.DataBindXY(Libro, Cant);

            registro.Close();
            conexion.Close();


        }

        ArrayList Libro1 = new ArrayList();
        ArrayList Cant1 = new ArrayList();


        public void GraficoDevRetrazos()
        {
            conexion.Open();
            string sql = "SELECT Lib_Titulo AS 'Título', sum(PresDet_Cantidad) AS 'Cantidad', stock_total AS 'stock actual' FROM libro  " +
                "JOIN prestamodetalle ON Lib_Id = PresDet_Lib_Id " +
                "JOIN stock ON stock_id = Stock_stock_id " +
                "JOIN prestamo ON Pres_Id = PresDet_Pres_Id " +
                "WHERE Pres_PresEs_Id = 2  AND Pres_Fech_Dev<Pres_FechaRealDev " +
                "GROUP BY Lib_Titulo " +
                "ORDER BY Lib_Titulo";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                Libro1.Add(registro.GetString(0));
                Cant1.Add(registro.GetInt32(1));
            }
            chartRepDevRetrazo.Series[0].Points.DataBindXY(Libro1, Cant1);
            registro.Close();
            conexion.Close();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
           
            conexion.Open();
            string sql = "SELECT Lib_Titulo AS 'Título', sum(PresDet_Cantidad) AS 'Cantidad' FROM libro  " +
                "JOIN prestamodetalle ON Lib_Id = PresDet_Lib_Id " +
                "JOIN stock ON stock_id = Stock_stock_id " +
                "JOIN prestamo ON Pres_Id = PresDet_Pres_Id " +
                "WHERE Pres_PresEs_Id = 2  AND Pres_FechaRealDev > @fecha1 AND Pres_FechaRealDev< @fecha2";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@fecha1", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
            comando.Parameters.Add("@fecha2", MySqlDbType.Date).Value = dateTimePicker2.Value.Date;
            MySqlDataReader registro = comando.ExecuteReader();
            if(registro.Read())
            {

                cantidad = registro["Cantidad"].ToString();
                label4.Text = cantidad.ToString();

            }
           
            
           
            registro.Close();

            string sql1 = "SELECT Lib_Titulo AS 'Título', sum(PresDet_Cantidad) AS 'Cantidad' FROM libro   " +
                "JOIN prestamodetalle ON Lib_Id = PresDet_Lib_Id " +
                "JOIN stock ON stock_id = Stock_stock_id " +
                "JOIN prestamo ON Pres_Id = PresDet_Pres_Id " +
                "WHERE Pres_PresEs_Id = 2  AND Pres_Fech_Dev<Pres_FechaRealDev AND Pres_FechaRealDev > @fecha1 AND Pres_FechaRealDev< @fecha2";
            MySqlCommand comando1 = new MySqlCommand(sql1, conexion);
            comando1.Parameters.Add("@fecha1", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
            comando1.Parameters.Add("@fecha2", MySqlDbType.Date).Value = dateTimePicker2.Value.Date;
            MySqlDataReader registro1 = comando1.ExecuteReader();
            if (registro1.Read())
            {

               cantidad1 = registro1["Cantidad"].ToString();
                labelVencidos.Text = cantidad1.ToString();

            }
            
            

            registro1.Close();

            conexion.Close();


        }
    }
}

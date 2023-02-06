using Microsoft.Win32;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
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
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;
using iTextSharp.tool.xml;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;
using System.Drawing.Printing;
using Font = System.Drawing.Font;

namespace WindowsFormsApp1
{

    public partial class ReportePrestamos : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
        int libDisp;
        int libPres;
        int totalLib;
        int vencidos;

        public ReportePrestamos()
        {
            InitializeComponent();

            reporte.Text = "Reporte de Libros en prestamo";
            reporte.WindowState = FormWindowState.Maximized;
        }

        private void ReportePrestamos_Load(object sender, EventArgs e)
        {
            MostrarTabla();
            Grafico();
            DatosPrestamo();
            DisponibilidadLibros();
            TotalStock();
            PresVencidos();
        }
        ArrayList Libro = new ArrayList();
        ArrayList Cant = new ArrayList();
        public void Grafico()
        {
            conexion.Open();
            string sql = "SELECT Lib_Titulo AS 'Título', sum(PresDet_Cantidad) AS 'Cantidad', stock_total AS 'stock actual' FROM libro  " +
                "JOIN prestamodetalle ON Lib_Id = PresDet_Lib_Id " +
                "JOIN stock ON stock_id = Stock_stock_id " +
                "JOIN prestamo ON Pres_Id = PresDet_Pres_Id " +
                "WHERE Pres_PresEs_Id = 1 " +
                "GROUP BY Lib_Titulo " +
                "ORDER BY Lib_Titulo";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                Libro.Add(registro.GetString(0));
                Cant.Add(registro.GetInt32(1));
            }
            chartRepPres.Series[0].Points.DataBindXY(Libro,Cant);
            registro.Close();
            conexion.Close();

        }

        private void DatosPrestamo()
        {
            conexion.Open();
            String sql = "SELECT COUNT(Pres_Id) AS 'Total' FROM prestamo  " +
                "WHERE Pres_Fech_Dev<= NOW() AND Pres_PresEs_Id = 1";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                libPres = int.Parse(registro["Total"].ToString());
                labelTotPres.Text = registro["Total"].ToString();// cantidad prestamos vigentes
            }
            registro.Close();
            conexion.Close();
        }

        public void TotalStock()
        {
            libDisp = libPres + totalLib;
            labeltotal.Text=libDisp.ToString();
        }

        public void DisponibilidadLibros()
        {
            conexion.Open();
            string sql = "SELECT SUM(stock_total) AS 'stock' FROM stock";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                totalLib = int.Parse(registro["stock"].ToString());// guardo libros en stock
                labeldispo.Text = registro["stock"].ToString();
            }
           
            registro.Close();
            conexion.Close();

        }

        public void PresVencidos()
        {
            conexion.Open();
            string sql = "SELECT COUNT(Pres_Id) AS 'Total' FROM prestamo  " +
                "WHERE Pres_Fech_Dev<= NOW() AND Pres_PresEs_Id = 1";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registro = comando.ExecuteReader();


            if (registro.Read())
            {
                vencidos= int.Parse(registro["Total"].ToString());// guardo cantidad prestamos vencidos a la fecha 
                labelVencidos.Text = registro["Total"].ToString();
            }
            registro.Close();
            conexion.Close();

        }


        public void MostrarTabla()
        {
            conexion.Open();
            string sql = "SELECT Lib_Titulo,Pres_Id,Pres_Fecha_Entrega,Pres_Fech_Dev,Soc_Dni,Soc_Nombre,Soc_Apellido,Soc_Telef,PresDet_Cantidad,Usu_Nombre FROM prestamo   " +
                "JOIN socio ON Soc_Id = Pres_Soc_Id " +
                "JOIN prestamodetalle ON Pres_Id = PresDet_Pres_Id " +
                "JOIN libro ON Lib_Id = PresDet_Lib_Id " +
                "JOIN stock ON stock_id = Stock_stock_id " +
                "JOIN usuario ON Usu_Id = Pres_Usu_Id " +
                "WHERE Pres_PresEs_Id = 1 " +
                "ORDER BY Lib_Titulo";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registro = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registro.Read())
            {
               

                dataGridView1.Rows.Add(registro["Pres_Id"].ToString(),
                                    registro["Lib_Titulo"].ToString(),
                                     registro["Pres_Fecha_Entrega"].ToString(),
                                    registro["Pres_Fech_Dev"].ToString(),
                                    registro["Soc_Dni"].ToString(),
                                    registro["Soc_Nombre"].ToString(),
                                    registro["Soc_Apellido"].ToString(),
                                    registro["Soc_Telef"].ToString(),
                                    registro["PresDet_Cantidad"].ToString(),
                                    registro["Usu_Nombre"].ToString());

            }
            registro.Close();
            conexion.Close();



        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Pres_Fech_Dev")
            {
                DateTime fecha = DateTime.Today;
                if (Convert.ToDateTime(e.Value) <= fecha)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.DarkSeaGreen;
                }
            }
        }

       
    }
}

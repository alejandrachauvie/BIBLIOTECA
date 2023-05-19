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
    public partial class Socios : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
        int pos;
        int socioId;
        public Socios()
        {
            InitializeComponent();
            buttonEditar.Enabled = false;
            buttonEliminar.Enabled = false;
        }

        private void Socios_Load(object sender, EventArgs e)
        {
            CargarEstadoSocio();
            CargarLocalidad();
            CargarProvincia();
            CargarPais();
            MostrarTabla();

        }

        private void CargarPais()
        {
            conexion.Open();
            string sql = "select Pais_Id,Pais_Nombre from pais";
            MySqlDataAdapter adaptador1 = new MySqlDataAdapter();

            adaptador1.SelectCommand = new MySqlCommand(sql, conexion);

            DataTable tabla = new DataTable();
            adaptador1.Fill(tabla);
            tabla.Rows.Add(0, "Selecciona País");
            tabla.DefaultView.Sort = "Pais_id";
            comboPais.DataSource = tabla;
            comboPais.DisplayMember = "Pais_Nombre";
            comboPais.ValueMember = "Pais_id";
            conexion.Close();
        }

       

        public void CargarProvincia()
        {
            conexion.Open();
            string sql = "select Prov_Id,Prov_Nombre from provincia";
            MySqlDataAdapter adaptador1 = new MySqlDataAdapter();
            adaptador1.SelectCommand = new MySqlCommand(sql, conexion);

            DataTable tabla = new DataTable();
            adaptador1.Fill(tabla);
            tabla.Rows.Add( 0, "Selecciona Provincia");
            tabla.DefaultView.Sort = "Prov_id";
            comboProv.DataSource = tabla;
            comboProv.DisplayMember = "Prov_Nombre";
            comboProv.ValueMember = "Prov_id";
            
            conexion.Close();

        }

        public void CargarLocalidad()
        {
            conexion.Open();
            string sql = "select Local_Id,Local_Nombre from localidad ";
            MySqlDataAdapter adaptador1 = new MySqlDataAdapter();
            adaptador1.SelectCommand = new MySqlCommand(sql, conexion);

            DataTable tabla = new DataTable();
            adaptador1.Fill(tabla);
            tabla.Rows.Add( 0 , "Selecciona Localidad");
            tabla.DefaultView.Sort = "Local_Id";

            comboLocalidad.DataSource = tabla;
            comboLocalidad.DisplayMember = "Local_Nombre";
            comboLocalidad.ValueMember = "Local_Id";
       
            conexion.Close();
        }

        public void CargarEstadoSocio()
        {
            conexion.Open();
            string sql = "SELECT SocEs_Id,SocEs_Descripcion FROM socioestado ";
            MySqlDataAdapter adaptador1 = new MySqlDataAdapter();
            adaptador1.SelectCommand = new MySqlCommand(sql, conexion);

            DataTable tabla = new DataTable();
            adaptador1.Fill(tabla);
            tabla.Rows.Add(0, "Selecciona Estado");
            tabla.DefaultView.Sort = "SocEs_Id";

            comboEstado.DataSource = tabla;
            comboEstado.DisplayMember = "SocEs_Descripcion";
            comboEstado.ValueMember = "SocEs_Id";
            conexion.Close();
        }

        private bool ExisteTelefono()
        {
            conexion.Open();
            string sql = "SELECT * FROM socio WHERE Soc_Telef=@telef";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@telef", MySqlDbType.VarChar).Value = textTelef.Text;
            bool existe = false;
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())

                existe = true;
            conexion.Close();
            return existe;
        }

        private bool ExisteDni()
        {
            conexion.Open();
            string sql = "SELECT * FROM socio WHERE Soc_Dni=@dni";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textDNI.Text;
            bool existe = false;
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            
                existe = true;
            conexion.Close();
            return existe;
            
        }

        private bool TienePrestamo()
        {
            conexion.Open();
            string sql = "SELECT Pres_Soc_Id,Pres_PresEs_Id FROM prestamo " +
                "JOIN socio ON Soc_id = Pres_Soc_Id WHERE Soc_Dni =@dni";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textDNI.Text;
            bool existe = false;
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())

                existe = true;
            conexion.Close();
            return existe;
        }

        public void Limpiar()
        {
            checkBox1.Checked = false;
            textMatricula.Text = "";
            textNombre.Text = "";
            textDpto.Text = "";
            textApellido.Text = "";
            textDNI.Text = "";
            textTelef.Text = "";
            textDireccion.Text = "";
            textNumero.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label31.Text = "";
            label32.Text = "";
            label37.Text = "";
            label38.Text = "";
            comboEstado.SelectedIndex = 0;
            comboPiso.SelectedIndex = 0;
            comboLocalidad.SelectedIndex = 0;
            comboProv.SelectedIndex = 0;
            comboPais.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ExisteDni())
            {
                MessageBox.Show("Ya existe un Socio con ese Dni " , "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ExisteTelefono())
            {
                MessageBox.Show("Ya existe ese teléfono registrado en un socio" , "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (textMatricula.Text == "")
            {
                MessageBox.Show("Debe ingresar Monto de Matricula ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textMatricula.Focus();
                return;
            }

            if (textNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar Nombre" , "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNombre.Focus();
                return;
            }
            if (textApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar Apellido" , "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textApellido.Focus();
                return;
            }
            if (textDNI.Text == "")
            {
                MessageBox.Show("Debe ingresar DNI", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textDNI.Focus();
                return;
            }
          

            if (textTelef.Text == "")
            {
                MessageBox.Show("Debe ingresar teléfono", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textTelef.Focus();
                return;
            }
            if (int.Parse(comboEstado.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Debe seleccionar Estado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboEstado.Focus();
                return;
            }
            if (textDireccion.Text == "")
            {
                MessageBox.Show("Debe ingresar Direccion", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textDireccion.Focus();
                return;
            }
            if (textNumero.Text == "")
            {
                MessageBox.Show("Debe ingresar Número", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNumero.Focus();
                return;
            }
            if (int.Parse(comboLocalidad.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Debe seleccionar Localidad", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboLocalidad.Focus();
                return;
            }
            if (int.Parse(comboProv.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Debe seleccionar Provincia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboProv.Focus();
                return;
            }
            if (int.Parse(comboPais.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Debe seleccionar País", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboPais.Focus();
                return;
            }


            else 
            {
                conexion.Open();
                string sql = "INSERT INTO inscripcion (Insc_Fecha,Insc_InscEs_Id) VALUE (NOW(),@estado)";
                MySqlCommand comando0 = new MySqlCommand(sql, conexion);

                if (checkBox1.Checked)//chequeamos si pago 
                {
                    comando0.Parameters.Add("@estado", MySqlDbType.Int16).Value = 1;
                }
                else
                {
                    comando0.Parameters.Add("@estado", MySqlDbType.Int16).Value = 3;
                }
                comando0.ExecuteNonQuery();

                //consulto numero inscripcion 
                string consultasql = "SELECT  MAX(Insc_Id ) AS 'id' FROM inscripcion";
                MySqlCommand comandoc = new MySqlCommand(consultasql, conexion);
                MySqlDataReader registroc = comandoc.ExecuteReader();
                if (registroc.Read())
                {
                    label16.Text = registroc["id"].ToString();//guardo el id ultima inscripcion
                }
                registroc.Close();



                if (textDireccion.Text != "" && textNumero.Text != "")
                {

                    string sql1 = "insert into domicilio (Dom_Calle,Dom_Numero,Dom_Piso,Dom_Apto,Dom_Local_Id) values (@calle,@numero,@piso,@apto,@codigoLocalidad)";
                    MySqlCommand comando = new MySqlCommand(sql1, conexion);
                    comando.Parameters.Add("@calle", MySqlDbType.VarChar).Value = textDireccion.Text;
                    comando.Parameters.Add("@numero", MySqlDbType.VarChar).Value = textNumero.Text;
                    comando.Parameters.Add("@apto", MySqlDbType.VarChar).Value = textDpto.Text;
                    comando.Parameters.Add("@piso", MySqlDbType.VarChar).Value = comboPiso.SelectedItem;
                    comando.Parameters.Add("@codigoLocalidad", MySqlDbType.Int16).Value = comboLocalidad.SelectedValue.ToString();
                    comando.ExecuteNonQuery();
                }

                //consulto la tabla domicilio
                string sql2 = "select Dom_Id from domicilio where Dom_Calle=@calle and Dom_Numero= @numero ";
                MySqlCommand comando1 = new MySqlCommand(sql2, conexion);
                comando1.Parameters.Add("@calle", MySqlDbType.VarChar).Value = textDireccion.Text;
                comando1.Parameters.Add("@numero", MySqlDbType.VarChar).Value = textNumero.Text;
               

                MySqlDataReader registroid = comando1.ExecuteReader();
                if (registroid.Read())
                {
                    label17.Text = registroid["Dom_Id"].ToString();//guardo id domicilio
                }
                registroid.Close();

                if (textNombre.Text!="" && textApellido.Text!="")
                {

                    //almacenar id domicilio en variable
                    string sql3 = "insert into socio (Soc_Nombre,Soc_Apellido,Soc_Dni,Soc_Telef,Soc_Dom_Id,Soc_SocEs_Id) VALUES " +
                        "(@nombre,@apellido,@dni,@telef,@idcalle,@tipoestado)";
                    MySqlCommand comando2 = new MySqlCommand(sql3, conexion);
                    comando2.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = textNombre.Text;
                    comando2.Parameters.Add("@apellido", MySqlDbType.VarChar).Value = textApellido.Text;
                    comando2.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textDNI.Text;
                    comando2.Parameters.Add("@telef", MySqlDbType.VarChar).Value = textTelef.Text;
                    comando2.Parameters.Add("@idcalle", MySqlDbType.Int16).Value = label17.Text;
                    comando2.Parameters.Add("@tipoestado", MySqlDbType.Int16).Value = comboEstado.SelectedValue.ToString();
                    comando2.ExecuteNonQuery();

                    //consulto id socio para cargar el detalle de inscripcion
                    string sql4 = "Select Soc_Id from socio where Soc_dni=@dni";
                    MySqlCommand comando3 = new MySqlCommand(sql4, conexion);
                    comando3.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textDNI.Text;
                    MySqlDataReader registro4 = comando3.ExecuteReader();
                    if (registro4.Read())
                    {
                        socioId = int.Parse(registro4["Soc_Id"].ToString());
                        label18.Text = registro4["Soc_Id"].ToString();//guardo id socio cargado
                    }
                    registro4.Close();

                    // cargo detalleinscripcion
                    string sql5 = "INSERT INTO inscripciondetalle (InscDet_Monto,InscDet_Insc_Id,InscDet_Soc_Id) VALUE (@monto,@inscid,@socioid)";
                    MySqlCommand comando4 = new MySqlCommand(sql5, conexion);
                    comando4.Parameters.Add("@monto", MySqlDbType.Decimal).Value = textMatricula.Text;
                    comando4.Parameters.Add("@inscid", MySqlDbType.Int16).Value = label16.Text;
                    comando4.Parameters.Add("@socioid", MySqlDbType.Int16).Value =socioId;
                    //  comando4.Parameters.Add("@socioid", MySqlDbType.Int16).Value = label18.Text;
                    comando4.ExecuteNonQuery();
                   

                }
                Limpiar();

                MessageBox.Show("Los datos fueron cargados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            conexion.Close();
            MostrarTabla();
        }

        public void MostrarTabla()
        {
            conexion.Open();
            string sql = "SELECT Soc_Nombre,Soc_Apellido,Soc_Dni,Soc_Telef,SocEs_Descripcion,Dom_Calle,Dom_Numero,Dom_piso,Dom_Apto,Local_Nombre,Prov_Nombre,Pais_Nombre,InscDet_Monto,InscEs_Descripcion FROM socio  " +
                "JOIN domicilio ON Dom_Id = Soc_Dom_Id " +
                "JOIN localidad ON Local_Id = Dom_Local_Id " +
                "JOIN provincia ON Prov_Id = Local_Prov_Id " +
                "JOIN pais ON Pais_Id = Prov_Pais_Id " +
                "JOIN socioestado ON SocEs_Id = Soc_SocEs_Id " +
                "JOIN inscripcion ON Insc_Id " +
                "JOIN inscripciondetalle ON InscDet_Soc_Id = Soc_Id AND InscDet_Insc_Id = Insc_Id " +
                "JOIN inscripcionestado ON InscEs_Id = Insc_InscEs_Id " +
                "ORDER BY Soc_Nombre";
            MySqlCommand comando = new MySqlCommand(sql,conexion);
            MySqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["Soc_Nombre"].ToString(),
                                        registros["Soc_Apellido"].ToString(),
                                        registros["Soc_Dni"].ToString(),
                                        registros["Soc_Telef"].ToString(),
                                        registros["SocEs_Descripcion"].ToString(),
                                        registros["Dom_Calle"].ToString(),
                                        registros["Dom_Numero"].ToString(),
                                        registros["Dom_Apto"].ToString(),
                                        registros["Dom_piso"].ToString(),
                                        registros["Local_Nombre"].ToString(),
                                        registros["Prov_Nombre"].ToString(),
                                        registros["Pais_Nombre"].ToString(),
                                        registros["InscDet_Monto"].ToString(),
                                        registros["InscEs_Descripcion"].ToString());
            }
            registros.Close();
            conexion.Close();



        }
       


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if (textDNI.Text == "")
            {
                MessageBox.Show("Debe ingresar DNI para realizar consulta");
                textDNI.Focus();
                return;
            }

            else
            {
                conexion.Open();
                string sql = "SELECT InscDet_Monto,InscEs_Descripcion,Soc_Nombre,Soc_Apellido,Soc_Telef,SocEs_Id,Dom_Calle,Dom_Numero,Dom_piso,Dom_Apto,Local_Id,Prov_Id,Pais_Id FROM socio " +
                    "JOIN domicilio ON Dom_Id = Soc_Dom_Id " +
                    "JOIN localidad ON Local_Id " +
                    "JOIN socioestado ON SocEs_Id = Soc_SocEs_Id " +
                    "JOIN inscripcion ON Insc_InscEs_Id " +
                    "JOIN inscripciondetalle ON InscDet_Monto " +
                    "JOIN inscripcionestado ON InscEs_Id = Insc_InscEs_Id " +
                    "JOIN provincia ON Prov_Id " +
                    "JOIN pais ON Pais_Id " +
                    "WHERE Soc_Dni = @dni";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textDNI.Text;
                MySqlDataReader registros = comando.ExecuteReader();

                dataGridView1.Rows.Clear();
                bool existe = false;
                while (registros.Read())
                {
                    existe = true;
                    textMatricula.Text = registros["InscDet_Monto"].ToString();
                    if (registros["InscEs_Descripcion"].ToString() == "Pago")
                    {
                        checkBox1.Checked = true;
                    }
                    else
                    {
                        checkBox1.Checked = false;
                    }
                    textNombre.Text = registros["Soc_Nombre"].ToString();
                    textApellido.Text = registros["Soc_Apellido"].ToString();
                    textTelef.Text = registros["Soc_Telef"].ToString();
                    comboEstado.SelectedValue = registros["SocEs_Id"].ToString();
                    textDireccion.Text = registros["Dom_Calle"].ToString();
                    textNumero.Text = registros["Dom_Numero"].ToString();
                    textDpto.Text = registros["Dom_Apto"].ToString();
                    comboPiso.SelectedItem = registros["Dom_piso"].ToString();
                    comboLocalidad.SelectedValue = registros["Local_Id"].ToString();
                    comboProv.SelectedValue = registros["Prov_Id"].ToString();
                    comboPais.SelectedValue = registros["Pais_Id"].ToString();


                }
                conexion.Close();
                if (existe == false)
                {
                    MessageBox.Show("No existe ningun socio con ese DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MostrarTabla();
            buttonEditar.Enabled = true;
            buttonEliminar.Enabled = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditar_Click_1(object sender, EventArgs e)
        {
            

            if (textDNI.Text == "")
            {
                MessageBox.Show("Debe realizar una consulta para poder modificar datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textDNI.Focus();
                return;
            }
            if (textNombre.Text == "")
            {
                MessageBox.Show("Debe realizar una consulta para poder modificar datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNombre.Focus();
                return;
            }

            if (textApellido.Text == "")
            {
                MessageBox.Show("Debe realizar una consulta para poder modificar datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textApellido.Focus();
                return;
            }
            if (textTelef.Text == "")
            {
                MessageBox.Show("Debe realizar una consulta para poder modificar datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textTelef.Focus();
                return;
            }
            if (int.Parse(comboEstado.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Debe realizar una consulta para poder modificar datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboEstado.Focus();
                return;
            }

            if (textDireccion.Text == "")
            {
                MessageBox.Show("Debe realizar una consulta para poder modificar datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textDireccion.Focus();
                return;
            }

            if (textNumero.Text == "")
            {
                MessageBox.Show("Debe realizar una consulta para poder modificar datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNumero.Focus();
                return;
            }
            if (int.Parse(comboLocalidad.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Debe realizar una consulta para poder modificar datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboLocalidad.Focus();
                return;
            }
            if (int.Parse(comboProv.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Debe realizar una consulta para poder modificar datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboProv.Focus();
                return;
            }
            if (int.Parse(comboPais.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Debe realizar una consulta para poder modificar datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboPais.Focus();
                return;
            }
            else
            {
                
                conexion.Open();
                string sql = "UPDATE socio SET Soc_Nombre= @nombre, Soc_Apellido= @apellido, Soc_Telef= @telefono, Soc_SocEs_Id=@socestado" +
                    " WHERE Soc_Dni = @dni";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = textNombre.Text;
                comando.Parameters.Add("@apellido", MySqlDbType.VarChar).Value = textApellido.Text;
                comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textDNI.Text;
                comando.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = textTelef.Text;
                comando.Parameters.Add("@socestado", MySqlDbType.VarChar).Value = comboEstado.SelectedValue.ToString();


                int cant1 = comando.ExecuteNonQuery();
            }
            //busco el domicilio a modificar
            string sql2 = "SELECT Soc_Dom_Id FROM socio" +
                          " JOIN domicilio ON Dom_Id = Soc_Dom_Id " +
                            "WHERE Soc_Dni =@dni";
            MySqlCommand comando1 = new MySqlCommand(sql2, conexion);
            comando1.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textDNI.Text;
            MySqlDataReader registro = comando1.ExecuteReader();
            if (registro.Read())
            {
                label31.Text = registro["Soc_Dom_Id"].ToString();
            }
            registro.Close();

            // modifico domicilio 
            string sql3 = "UPDATE domicilio SET Dom_Calle=@calle ,Dom_Numero=@numero,Dom_piso=@piso,Dom_Apto=@depto" +
                " WHERE Dom_Id = @codigodomicilio";
            MySqlCommand comando2 = new MySqlCommand(sql3, conexion);
            comando2.Parameters.Add("@calle", MySqlDbType.VarChar).Value = textDireccion.Text;
            comando2.Parameters.Add("@numero", MySqlDbType.VarChar).Value = textNumero.Text;
            comando2.Parameters.Add("@piso", MySqlDbType.VarChar).Value = comboPiso.SelectedItem;
            comando2.Parameters.Add("@depto", MySqlDbType.VarChar).Value = textDpto.Text;
            comando2.Parameters.Add("@codigodomicilio", MySqlDbType.Int16).Value = label31.Text;

            int cant = comando2.ExecuteNonQuery();


            //modifico monto matricula
            string sql4 = "SELECT Soc_Id, InscDet_Insc_Id, InscDet_Id   FROM socio " +
                "JOIN inscripciondetalle ON InscDet_Soc_Id = Soc_Id " +
                "WHERE Soc_Dni = @dni";
            MySqlCommand comando4 = new MySqlCommand(sql4, conexion);
            comando4.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textDNI.Text;
            MySqlDataReader registro4 = comando4.ExecuteReader();
            if (registro4.Read())
            {
                label32.Text = registro4["InscDet_Id"].ToString();//guardo id de inscripciondetalle
                label33.Text = registro4["InscDet_Insc_Id"].ToString();//guardo id de inscripcion
                
            }
            registro4.Close();


            string sql5 = "UPDATE inscripciondetalle SET InscDet_Monto=@monto " +
                "WHERE InscDet_Id = @inscdetid";
            MySqlCommand comando5 = new MySqlCommand(sql5, conexion);
            comando5.Parameters.Add("@monto", MySqlDbType.VarChar).Value = textMatricula.Text;
            comando5.Parameters.Add("@inscdetid", MySqlDbType.VarChar).Value = label32.Text;
            int cant2 = comando5.ExecuteNonQuery();


            string sql6 = "UPDATE inscripcion SET Insc_InscEs_Id=@inscestado WHERE Insc_Id = @inscid";
            MySqlCommand comando6 = new MySqlCommand(sql6, conexion);
            if (checkBox1.Checked)//actualizamos  el  pago en caso de equivocarnos al cargar
            {
                comando6.Parameters.Add("@inscestado", MySqlDbType.Int16).Value = 1;
            }
            else
            {
                comando6.Parameters.Add("@inscestado", MySqlDbType.Int16).Value = 3;
            }
           
            comando6.Parameters.Add("@inscid", MySqlDbType.VarChar).Value = label33.Text;
            int cant3 = comando6.ExecuteNonQuery();


            conexion.Close();
            if (cant3 == 1 && cant2==1)
            {
                Limpiar();

                MessageBox.Show("Los datos fueron actualizados");

            }
            else
            {
                MessageBox.Show("No se pudo actualizar ");
            }
            MostrarTabla();
            buttonEditar.Enabled = false;
            buttonEliminar.Enabled = false;
        }

     

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
          
            if (textDNI.Text == "")
            {
                MessageBox.Show("Debe consultar primero si existe cliente para poder modificar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textDNI.Focus();
                return;
            }
            if (!ExisteDni())
            {
                MessageBox.Show("No existe un cliente con ese Dni", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textDNI.Focus();
                return;
            }
            if (TienePrestamo())
            {
                MessageBox.Show("No se puede eliminar el socio,tiene prestamos vigente", "Aténcion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                conexion.Open();
                string sql = "SELECT Soc_Id,Dom_Id,InscDet_Id,Insc_Id FROM socio " +
                    "JOIN domicilio ON Dom_Id = Soc_Dom_Id " +
                    "JOIN inscripciondetalle ON inscDet_Soc_Id = Soc_Id " +
                    "JOIN inscripcion ON Insc_Id = InscDet_Insc_Id " +
                    "WHERE Soc_Dni = @dni";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textDNI.Text;
                MySqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    label34.Text = registro["Soc_Id"].ToString();
                    label35.Text = registro["Dom_Id"].ToString();
                    label37.Text = registro["InscDet_Id"].ToString();
                    label38.Text = registro["Insc_Id"].ToString();

                }
                registro.Close();

              string sql1 = "DELETE FROM inscripciondetalle where InscDet_Id=@inscripcion";
                MySqlCommand comando1 = new MySqlCommand(sql1, conexion);
                comando1.Parameters.Add("@inscripcion", MySqlDbType.Int16).Value = label37.Text;
                int cant = comando1.ExecuteNonQuery();


               string sql2 = "DELETE FROM inscripcion WHERE Insc_Id=@in";
                MySqlCommand comando2 = new MySqlCommand(sql2, conexion);
                comando2.Parameters.Add("@in", MySqlDbType.Int16).Value = label38.Text;
                int cant1 = comando2.ExecuteNonQuery();

               
              

                string sql3 = "DELETE FROM socio WHERE Soc_Dni=@dni";
                MySqlCommand comando3 = new MySqlCommand(sql3, conexion);
                comando3.Parameters.Add("@dni", MySqlDbType.VarChar).Value = textDNI.Text;
                int cant2 = comando3.ExecuteNonQuery();



                string sql5 = "DELETE FROM domicilio WHERE Dom_Id=@id";
                MySqlCommand comando5 = new MySqlCommand(sql5, conexion);
                comando5.Parameters.Add("@id", MySqlDbType.Int16).Value = label35.Text;
                int cant3 = comando5.ExecuteNonQuery();



                conexion.Close();
                if (cant3 == 1)
                {
                    Limpiar();
                    MessageBox.Show("Se elimino el socio exitosamente!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                }
                else
                {
                    MessageBox.Show("No existe socio con ese dni");
                }
                MostrarTabla();
                buttonEditar.Enabled = false;
                buttonEliminar.Enabled = false;
            }





        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = dataGridView1.CurrentRow.Index;
            textNombre.Text = dataGridView1[0, pos].Value.ToString();
            textApellido.Text = dataGridView1[1, pos].Value.ToString();
            textDNI.Text = dataGridView1[2, pos].Value.ToString();
            textTelef.Text = dataGridView1[3, pos].Value.ToString();
            comboEstado.Text = dataGridView1[4, pos].Value.ToString();
            textDireccion.Text = dataGridView1[5, pos].Value.ToString();
            textNumero.Text = dataGridView1[6, pos].Value.ToString();
            textDpto.Text = dataGridView1[7, pos].Value.ToString();
            comboPiso.Text = dataGridView1[8, pos].Value.ToString();
            comboLocalidad.Text = dataGridView1[9, pos].Value.ToString();
            comboProv.Text = dataGridView1[10, pos].Value.ToString();
            comboPais.Text = dataGridView1[11, pos].Value.ToString();
            textMatricula.Text = dataGridView1[12, pos].Value.ToString();
            if (dataGridView1[13, pos].Value.ToString() == "Pago")
            {
                checkBox1.Checked=true;
            }
            else
            {
                checkBox1.Checked = false;
            }
            buttonEditar.Enabled = true;
            buttonEliminar.Enabled = true;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}

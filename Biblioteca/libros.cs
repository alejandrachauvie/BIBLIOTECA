using MySql.Data.MySqlClient;
using System;
using System.Activities.Expressions;
using System.Activities.Statements;
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
    public partial class libros : Form
    {
        private MySqlConnection conexion = new MySqlConnection("server=Localhost ; user id=root; password= ;persistsecurityinfo=True; database=biblio");
        int cantidad;
        int total;
        int stock;
        int estante;
        int idStock;
        int pos;

        public libros()
        {
            InitializeComponent();
            buttonEditar.Enabled = false;
            buttonEliminar.Enabled = false;
        }

        public void CargarEstadoLibro()
        {
            conexion.Open();
            string sql = "SELECT LibEs_Id,LibEs_Descripcion FROM libroestado";
            MySqlDataAdapter adaptador1 = new MySqlDataAdapter();
            adaptador1.SelectCommand = new MySqlCommand(sql, conexion);

            DataTable tabla = new DataTable();
            adaptador1.Fill(tabla);
            tabla.Rows.Add(0, "Selecciona Estado");
            tabla.DefaultView.Sort = "LibEs_Id";

            comboestadolibro.DataSource = tabla;
            comboestadolibro.DisplayMember = "LibEs_Descripcion";
            comboestadolibro.ValueMember = "LibEs_Id";
            conexion.Close();
        }

        public void CargarAutor()
        {
            conexion.Open();
            string sql = "SELECT Aut_id,Aut_Nombre FROM autor ORDER BY Aut_Nombre";
            MySqlDataAdapter adaptador1 = new MySqlDataAdapter();
            adaptador1.SelectCommand = new MySqlCommand(sql, conexion);

            DataTable tabla = new DataTable();
            adaptador1.Fill(tabla);
            tabla.Rows.Add(0, "Selecciona Autor");
            tabla.DefaultView.Sort = "Aut_id";

            comboautor.DataSource = tabla;
            comboautor.DisplayMember = "Aut_Nombre";
            comboautor.ValueMember = "Aut_id";
            conexion.Close();
        }

        public void CargarUbicacion()
        {
            conexion.Open();
            string sql = "SELECT Ubic_id,Ubic_Descripcion FROM Ubicacion ";
            MySqlDataAdapter adaptador1 = new MySqlDataAdapter();
            adaptador1.SelectCommand = new MySqlCommand(sql, conexion);

            DataTable tabla = new DataTable();
            adaptador1.Fill(tabla);
            tabla.Rows.Add(0, "Selecciona Ubicacion");
            tabla.DefaultView.Sort = "Ubic_id";

            comboubic.DataSource = tabla;
            comboubic.DisplayMember = "Ubic_Descripcion";
            comboubic.ValueMember = "Ubic_id";
            conexion.Close();
        }

        private bool ExisteAutor()
        {
            conexion.Open();
            string sql = "SELECT Aut_id FROM autor where Aut_Nombre=@autor";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@autor", MySqlDbType.VarChar).Value = textNomAut.Text;
            MySqlDataReader registro1 = comando.ExecuteReader();
            bool existe = false;
            if (registro1.Read())
            {
                existe = true;


            }
            conexion.Close();
            return existe;
        }

        public void CargarEditorial()
        {
            conexion.Open();
            string sql = "SELECT Edit_id,Edit_Nombre FROM editorial ORDER BY Edit_Nombre";
            MySqlDataAdapter adaptador1 = new MySqlDataAdapter();
            adaptador1.SelectCommand = new MySqlCommand(sql, conexion);

            DataTable tabla = new DataTable();
            adaptador1.Fill(tabla);
            tabla.Rows.Add(0, "Selecciona Editorial");
            tabla.DefaultView.Sort = "Edit_id";

            comboedit.DataSource = tabla;
            comboedit.DisplayMember = "Edit_Nombre";
            comboedit.ValueMember = "Edit_id";
            conexion.Close();
        }

        private bool ExisteEditorial()
        {
            conexion.Open();
            string sql = "SELECT Edit_id FROM editorial where Edit_Nombre= @editorial";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@editorial", MySqlDbType.VarChar).Value = textNomEdit.Text;
            MySqlDataReader registro1 = comando.ExecuteReader();
            bool existe = false;
            if (registro1.Read())
            {
                existe = true;


            }
            conexion.Close();
            return existe;
        }

        private bool ExisteLibro()
        {
            conexion.Open();
            string sql = "SELECT * FROM libro WHERE Lib_Titulo=@titulo";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = textitulo.Text;
            bool existe = false;
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                existe = true;


            }
            conexion.Close();
            return existe;
        }

        private bool TienePrestamo()
        {
            conexion.Open();
            string sql = "SELECT PresDet_Lib_Id FROM prestamodetalle " +
                "JOIN libro  ON Lib_Id = PresDet_Lib_Id " +
                "WHERE Lib_Titulo = @libro";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.Add("@libro", MySqlDbType.VarChar).Value = textitulo.Text;
            bool existe = false;
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())

                existe = true;
            conexion.Close();
            return existe;
        }

        public void MostrarTabla()
        {
            conexion.Open();
            string sql = "SELECT Lib_Titulo,Lib_cantHojas,Lib_Descripcion,LibEs_Descripcion,Aut_Nombre,Edit_Nombre,Esta_Descripcion,Ubic_Descripcion,stock_total FROM libro " +
                "JOIN libroestado ON LibEs_id = Lib_LibEs_id " +
                "JOIN autor ON Aut_id = Lib_Aut_id " +
                "JOIN editorial ON Edit_id = Lib_Edit_id " +
                "JOIN estante ON Esta_id = Lib_Esta_id " +
                "JOIN ubicacion ON Ubic_id = Esta_Ubic_id " +
                "JOIN stock ON stock_id = stock_stock_id " +
                "ORDER BY Lib_Titulo";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            MySqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["Lib_Titulo"].ToString(),
                                       registros["Lib_cantHojas"].ToString(),
                                       registros["Lib_Descripcion"].ToString(),
                                       registros["LibEs_Descripcion"].ToString(),
                                        registros["Aut_Nombre"].ToString(),
                                       registros["Edit_Nombre"].ToString(),
                                       registros["Esta_Descripcion"].ToString(),
                                        registros["Ubic_Descripcion"].ToString(),
                                        registros["stock_total"].ToString());

            }
            registros.Close();
            conexion.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ExisteAutor())
            {
                MessageBox.Show("Ya existe el Autor ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNomAut.Focus();
                return;
            }
            else
            {
                conexion.Open();
                string sql = "INSERT INTO autor (Aut_Nombre) VALUES (@autor)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@autor", MySqlDbType.VarChar).Value = textNomAut.Text;
                comando.ExecuteNonQuery();

            }
            conexion.Close();
            textNomAut.Text = "";
            MessageBox.Show("Los datos fueron guardados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEditorial_Click(object sender, EventArgs e)
        {
            if (ExisteEditorial())
            {
                MessageBox.Show("Ya existe la Editorial ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNomEdit.Focus();
                return;
            }
            else
            {
                conexion.Open();
                string sql = "INSERT INTO editorial (Edit_Nombre) VALUES (@editorial)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@editorial", MySqlDbType.VarChar).Value = textNomEdit.Text;
                comando.ExecuteNonQuery();


            }
            conexion.Close();
            textNomEdit.Text = "";
            MessageBox.Show("Los datos fueron guardados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void libros_Load(object sender, EventArgs e)
        {
            MostrarTabla();
            CargarEstadoLibro();
            CargarAutor();
            CargarEditorial();
            CargarUbicacion();

        }
        public void blanquearFormulario()
        {
            textitulo.Text = "";
            textpag.Text = "";
            textdescripcion.Text = "";
            comboestadolibro.SelectedIndex = 0;
            comboautor.SelectedIndex = 0;
            comboedit.SelectedIndex = 0;
            comboestante.SelectedIndex = 0;
            comboubic.SelectedIndex = 0;
            label18.Text = "";
            textCantidad.Text = "";
            buttonEditar.Enabled = false;
            buttonEliminar.Enabled = false;
        }



        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "stock_cantidad")
            {
                if (Convert.ToInt32(e.Value) <= 3)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.DarkSeaGreen ;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ExisteLibro())
            {
                MessageBox.Show("Ya existe el Libro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textitulo.Focus();
                return;
            }
            if (textpag.Text == "")
            {
                MessageBox.Show("Debe ingresar cantidad de páginas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textpag.Focus();
                return;
            }
            if (textdescripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripcion", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textdescripcion.Focus();
                return;
            }
            if (int.Parse(comboestadolibro.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Debe seleccionar Estado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboestadolibro.Focus();
                return;
            }
            if (int.Parse(comboautor.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Debe seleccionar un Autor, si no existe debera cargarlo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboautor.Focus();
                return;
            }
            if (int.Parse(comboedit.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Debe seleccionar una Editorial, si no existe debera cargarla ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboedit.Focus();
                return;
            }
            if (int.Parse(comboubic.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Debe seleccionar la ubicacion del libro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboubic.Focus();
                return;
            }
            if (comboestante.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar N° Estante donde sera guardado el libro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboestante.Focus();
                return;
            }
            if (textCantidad.Text == "")
            {
                MessageBox.Show("Debe seleccionar cantidad", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCantidad.Focus();
                return;
            }
            else
            {
                conexion.Open();
                string sql = "INSERT INTO estante (Esta_Descripcion,Esta_Ubic_Id) VALUES (@estante, @ubicacion)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@estante", MySqlDbType.VarChar).Value = comboestante.SelectedItem;
                comando.Parameters.Add("@ubicacion", MySqlDbType.Int16).Value = comboubic.SelectedValue.ToString();
                comando.ExecuteNonQuery();


                string sql6 = "SELECT  MAX(Esta_id ) AS 'id' FROM estante";
                MySqlCommand comando6 = new MySqlCommand(sql6, conexion);

                MySqlDataReader registro2 = comando6.ExecuteReader();
                if (registro2.Read())
                {
                    label18.Text = registro2["id"].ToString();// guardo id estante
                }
                registro2.Close();

                //insertamos el stock
                string sql1 = "INSERT INTO stock (stock_cantidad,stock_total) VALUES (@cantidad,@total)";
                MySqlCommand comando1 = new MySqlCommand(sql1, conexion);
                comando1.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = textCantidad.Text;
                comando1.Parameters.Add("@total", MySqlDbType.Int32).Value = textCantidad.Text;
                comando1.ExecuteNonQuery();

                //consultamos el id stock
                string sql2 = "SELECT  MAX(stock_id) AS 'id' FROM stock";
                MySqlCommand comando2 = new MySqlCommand(sql2, conexion);
                MySqlDataReader registrouno = comando2.ExecuteReader();
                if (registrouno.Read())
                {
                    label20.Text = registrouno["id"].ToString();//guardo id stock
                }
                registrouno.Close();


                //insertamos el libro
                if (textitulo.Text != "")
                {
                    string sql3 = "INSERT INTO libro (Lib_Titulo,Lib_cantHojas,Lib_Descripcion,Lib_LibEs_Id,Lib_Aut_id,Lib_Edit_id,Lib_Esta_id,stock_stock_id)  VALUES " +
                        "(@titulo,@canthojas,@descripcion, @estado, @autor, @editorial, @estante, @stock)";
                    MySqlCommand comando3 = new MySqlCommand(sql3, conexion);
                    comando3.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = textitulo.Text;
                    comando3.Parameters.Add("@canthojas", MySqlDbType.Int16).Value = textpag.Text;
                    comando3.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = textdescripcion.Text;
                    comando3.Parameters.Add("@estado", MySqlDbType.Int16).Value = comboestadolibro.SelectedValue.ToString();
                    comando3.Parameters.Add("@autor", MySqlDbType.Int16).Value = comboautor.SelectedValue.ToString();
                    comando3.Parameters.Add("@editorial", MySqlDbType.Int16).Value = comboedit.SelectedValue.ToString();
                    comando3.Parameters.Add("@estante", MySqlDbType.Int16).Value = label18.Text;
                    comando3.Parameters.Add("@stock", MySqlDbType.Int16).Value = label20.Text;
                    comando3.ExecuteNonQuery();

                }

                blanquearFormulario();

                MessageBox.Show("Se cargaron con exito los datos ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conexion.Close();
            MostrarTabla();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if (textitulo.Text == "")
            {
                MessageBox.Show("Debe ingresar Titulo del libro para realizar consulta", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textitulo.Focus();
                return;
            }
            else
            {
                conexion.Open();
                string sql = "SELECT Lib_cantHojas,Lib_Descripcion,Lib_LibEs_Id,Lib_Aut_id,Lib_Edit_id,Esta_Ubic_id,Esta_Descripcion,stock_total FROM libro " +
                    "JOIN estante ON Esta_id = Lib_Esta_id " +
                    "JOIN ubicacion ON Ubic_id = Esta_Ubic_id " +
                    "JOIN stock ON stock_id = stock_stock_id " +
                    "WHERE Lib_Titulo = @titulo";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = textitulo.Text;
                MySqlDataReader registros = comando.ExecuteReader();


                bool existe = false;
                while (registros.Read())
                {
                    existe = true;
                    textpag.Text = registros["Lib_cantHojas"].ToString();
                    textdescripcion.Text = registros["Lib_Descripcion"].ToString();
                    comboestadolibro.SelectedValue = registros["Lib_LibEs_Id"].ToString();
                    comboautor.SelectedValue = registros["Lib_Aut_id"].ToString();
                    comboedit.SelectedValue = registros["Lib_Edit_id"].ToString();
                    comboubic.SelectedValue = registros["Esta_Ubic_id"].ToString();
                    comboestante.SelectedItem = registros["Esta_Descripcion"].ToString();
                    textCantidad.Text = registros["stock_total"].ToString();


                }
                conexion.Close();
                if (existe == false)
                {
                    MessageBox.Show("No existe ningun Libro con ese Titulo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MostrarTabla();
            buttonEditar.Enabled = true;
            buttonEliminar.Enabled = true;

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (textitulo.Text == "")
            {
                MessageBox.Show("Debe realizar una consulta para poder modificar datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textitulo.Focus();
                return;
            }
            if (textdescripcion.Text == "")
            {
                MessageBox.Show("Debe realizar una consulta para poder modificar datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textdescripcion.Focus();
                return;
            }
            if (int.Parse(comboestadolibro.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Debe realizar una consulta para poder modificar datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboestadolibro.Focus();
                return;
            }
            if (int.Parse(comboautor.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Debe realizar una consulta para poder modificar datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboautor.Focus();
                return;
            }
            if (int.Parse(comboedit.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Debe realizar una consulta para poder modificar datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboedit.Focus();
                return;
            }
            if (int.Parse(comboubic.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Debe realizar una consulta para poder modificar datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboubic.Focus();
                return;
            }

            if (comboestante.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Debe realizar una consulta para poder modificar datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboestante.Focus();
                return;
            }
            if (textCantidad.Text == "")
            {
                MessageBox.Show("Debe realizar una consulta para poder modificar datos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCantidad.Focus();
                return;
            }
            else
            {
                conexion.Open();
                string sql = "SELECT stock_stock_id,stock_cantidad,stock_total FROM libro " +
                    "JOIN stock ON stock_id=stock_stock_id " +
                    "WHERE Lib_Titulo= @titulo";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = textitulo.Text;
                MySqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    labidstock.Text = registro["stock_stock_id"].ToString();// guardo el id stock
                    cantidad = int.Parse(registro["stock_cantidad"].ToString());//guardo la cantidad
                    total = int.Parse(registro["stock_total"].ToString());//guardo el total
                }
                registro.Close();

                string sql1 = "UPDATE libro SET Lib_cantHojas=@paginas, Lib_Descripcion=@descripcion,Lib_LibEs_Id=@estado, Lib_Aut_id=@autor,Lib_Edit_id=@editorial,stock_stock_id=@idstock " +
                  " WHERE Lib_Titulo = @titulo";
                MySqlCommand comando1 = new MySqlCommand(sql1, conexion);
                comando1.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = textitulo.Text;
                comando1.Parameters.Add("@paginas", MySqlDbType.Int32).Value = textpag.Text;
                comando1.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = textdescripcion.Text;
                comando1.Parameters.Add("@estado", MySqlDbType.Int32).Value = comboestadolibro.SelectedValue.ToString();
                comando1.Parameters.Add("@autor", MySqlDbType.Int32).Value = comboautor.SelectedValue.ToString();
                comando1.Parameters.Add("@editorial", MySqlDbType.Int32).Value = comboedit.SelectedValue.ToString();
                comando1.Parameters.Add("@idstock", MySqlDbType.Int32).Value = labidstock.Text;
                int cant = comando1.ExecuteNonQuery();


                string sql2 = "UPDATE stock SET stock_cantidad=@cant, stock_total=@total  WHERE stock_id=@id";
                MySqlCommand comando2 = new MySqlCommand(sql2, conexion);
                comando2.Parameters.Add("@id", MySqlDbType.Int32).Value = labidstock.Text;
                comando2.Parameters.Add("@cant", MySqlDbType.Int32).Value = textCantidad.Text;

                int canting = int.Parse(textCantidad.Text);
                int stock = canting + total;
                comando2.Parameters.Add("@total", MySqlDbType.Int32).Value = stock;

                int cant2 = comando2.ExecuteNonQuery();


                conexion.Close();
                if (cant2 == 1)
                {
                    blanquearFormulario();


                    MessageBox.Show("Los datos fueron actualizados");

                }
                else
                {
                    MessageBox.Show("No se pudo actualizar ");
                }

            }
            MostrarTabla();

        }
 

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (textitulo.Text == "")
            {
                MessageBox.Show("Debe consultar primero si existe el libro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textitulo.Focus();
                return;
            }
            if (!ExisteLibro())
            {
                MessageBox.Show("No existe un libro con ese titulo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textitulo.Focus();
                return;
            }
            if (TienePrestamo())
            {
                MessageBox.Show("El libro no se puede eliminar, esta en prestamo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
              
                   conexion.Open();
                   string sql1 = "SELECT  Lib_Esta_id ,stock_stock_id FROM libro  " +
                    "JOIN estante ON Esta_id = Lib_Esta_id " +
                    "JOIN stock ON stock_id = stock_stock_id " +
                    "WHERE Lib_Titulo = @titulo";
                    MySqlCommand comando1 = new MySqlCommand(sql1, conexion);
                    comando1.Parameters.Add("@titulo", MySqlDbType.VarChar).Value = textitulo.Text;
                    MySqlDataReader registro = comando1.ExecuteReader();
                    if (registro.Read())
                    {
                        estante = int.Parse( registro["Lib_Esta_id"].ToString()); // guardo id estante
                        idStock = int.Parse(registro["stock_stock_id"].ToString());// guardo id stock

                    }
                    registro.Close();

       
                    string sql = "DELETE FROM libro WHERE Lib_Titulo=@titulo";
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    comando.Parameters.Add("@Titulo", MySqlDbType.VarChar).Value = textitulo.Text;
                    int cant = comando.ExecuteNonQuery();


                    string sql4 = "DELETE FROM stock WHERE stock_id= @id";
                    MySqlCommand comando4 = new MySqlCommand(sql4, conexion);
                    comando4.Parameters.Add("@id", MySqlDbType.Int32).Value = idStock;
                    int cant0 = comando4.ExecuteNonQuery();



                    string sql2 = "DELETE FROM estante WHERE Esta_id=@estante";
                    MySqlCommand comando2 = new MySqlCommand(sql2, conexion);
                    comando2.Parameters.Add("@estante", MySqlDbType.VarChar).Value = estante;
                    int cant1 = comando2.ExecuteNonQuery();

                conexion.Close();

                    if (cant1 == 1 && cant0==1 && cant==1 )
                    {
                        blanquearFormulario();
                        MostrarTabla();

                        MessageBox.Show("Se elimino el libro exitosamente");

                    }

                MostrarTabla();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = dataGridView1.CurrentRow.Index;
            textitulo.Text = dataGridView1[0, pos].Value.ToString();
            textpag.Text = dataGridView1[1, pos].Value.ToString();
            textdescripcion.Text = dataGridView1[2, pos].Value.ToString();
            comboestadolibro.Text = dataGridView1[3, pos].Value.ToString();
            comboautor.Text = dataGridView1[4, pos].Value.ToString();
            comboedit.Text = dataGridView1[5, pos].Value.ToString();
            comboestante.Text = dataGridView1[6, pos].Value.ToString();
            comboubic.Text = dataGridView1[7, pos].Value.ToString();
            textCantidad.Text = dataGridView1[8, pos].Value.ToString();
            buttonEditar.Enabled = true;
            buttonEliminar.Enabled = true;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            blanquearFormulario();

        }
    }
}

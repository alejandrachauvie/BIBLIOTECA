namespace WindowsFormsApp1
{
    partial class Prestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pres_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soc_Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soc_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soc_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soc_Telef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lib_Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aut_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pres_Fecha_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pres_Fech_Dev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresDet_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pres_Usu_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBuscarSocio = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBuscarLibro = new System.Windows.Forms.Panel();
            this.checkBoxIntercambiar = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxEditorial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelFechas = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxConsultar = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.BDevolver = new System.Windows.Forms.Button();
            this.buttonBuscarNom = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonGrabar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelBuscarSocio.SuspendLayout();
            this.panelBuscarLibro.SuspendLayout();
            this.panelFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pres_Id,
            this.Soc_Dni,
            this.Soc_Nombre,
            this.Soc_Apellido,
            this.Soc_Telef,
            this.Lib_Titulo,
            this.Aut_Nombre,
            this.Edit_Nombre,
            this.Pres_Fecha_Entrega,
            this.Pres_Fech_Dev,
            this.PresDet_Cantidad,
            this.stock_total,
            this.Pres_Usu_Id});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.dataGridView1.Location = new System.Drawing.Point(224, 366);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.Size = new System.Drawing.Size(1042, 257);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // Pres_Id
            // 
            this.Pres_Id.HeaderText = "N° Prestamo";
            this.Pres_Id.MinimumWidth = 6;
            this.Pres_Id.Name = "Pres_Id";
            this.Pres_Id.ReadOnly = true;
            this.Pres_Id.Width = 125;
            // 
            // Soc_Dni
            // 
            this.Soc_Dni.HeaderText = "DNI";
            this.Soc_Dni.MinimumWidth = 6;
            this.Soc_Dni.Name = "Soc_Dni";
            this.Soc_Dni.ReadOnly = true;
            this.Soc_Dni.Width = 125;
            // 
            // Soc_Nombre
            // 
            this.Soc_Nombre.HeaderText = "Nombre";
            this.Soc_Nombre.MinimumWidth = 6;
            this.Soc_Nombre.Name = "Soc_Nombre";
            this.Soc_Nombre.ReadOnly = true;
            this.Soc_Nombre.Width = 125;
            // 
            // Soc_Apellido
            // 
            this.Soc_Apellido.HeaderText = "Apellido";
            this.Soc_Apellido.MinimumWidth = 6;
            this.Soc_Apellido.Name = "Soc_Apellido";
            this.Soc_Apellido.ReadOnly = true;
            this.Soc_Apellido.Width = 125;
            // 
            // Soc_Telef
            // 
            this.Soc_Telef.HeaderText = "Telefono";
            this.Soc_Telef.MinimumWidth = 6;
            this.Soc_Telef.Name = "Soc_Telef";
            this.Soc_Telef.ReadOnly = true;
            this.Soc_Telef.Width = 125;
            // 
            // Lib_Titulo
            // 
            this.Lib_Titulo.HeaderText = "Libro";
            this.Lib_Titulo.MinimumWidth = 6;
            this.Lib_Titulo.Name = "Lib_Titulo";
            this.Lib_Titulo.ReadOnly = true;
            this.Lib_Titulo.Width = 125;
            // 
            // Aut_Nombre
            // 
            this.Aut_Nombre.HeaderText = "Autor";
            this.Aut_Nombre.MinimumWidth = 6;
            this.Aut_Nombre.Name = "Aut_Nombre";
            this.Aut_Nombre.ReadOnly = true;
            this.Aut_Nombre.Width = 125;
            // 
            // Edit_Nombre
            // 
            this.Edit_Nombre.HeaderText = "Editorial";
            this.Edit_Nombre.MinimumWidth = 6;
            this.Edit_Nombre.Name = "Edit_Nombre";
            this.Edit_Nombre.ReadOnly = true;
            this.Edit_Nombre.Width = 125;
            // 
            // Pres_Fecha_Entrega
            // 
            this.Pres_Fecha_Entrega.HeaderText = "Retiró";
            this.Pres_Fecha_Entrega.MinimumWidth = 6;
            this.Pres_Fecha_Entrega.Name = "Pres_Fecha_Entrega";
            this.Pres_Fecha_Entrega.ReadOnly = true;
            this.Pres_Fecha_Entrega.Width = 125;
            // 
            // Pres_Fech_Dev
            // 
            this.Pres_Fech_Dev.HeaderText = "Devolución";
            this.Pres_Fech_Dev.MinimumWidth = 6;
            this.Pres_Fech_Dev.Name = "Pres_Fech_Dev";
            this.Pres_Fech_Dev.ReadOnly = true;
            this.Pres_Fech_Dev.Width = 125;
            // 
            // PresDet_Cantidad
            // 
            this.PresDet_Cantidad.HeaderText = "Cantidad";
            this.PresDet_Cantidad.MinimumWidth = 6;
            this.PresDet_Cantidad.Name = "PresDet_Cantidad";
            this.PresDet_Cantidad.ReadOnly = true;
            this.PresDet_Cantidad.Width = 125;
            // 
            // stock_total
            // 
            this.stock_total.HeaderText = "En Stock";
            this.stock_total.MinimumWidth = 6;
            this.stock_total.Name = "stock_total";
            this.stock_total.ReadOnly = true;
            this.stock_total.Width = 125;
            // 
            // Pres_Usu_Id
            // 
            this.Pres_Usu_Id.HeaderText = "Usuario";
            this.Pres_Usu_Id.MinimumWidth = 6;
            this.Pres_Usu_Id.Name = "Pres_Usu_Id";
            this.Pres_Usu_Id.ReadOnly = true;
            this.Pres_Usu_Id.Width = 125;
            // 
            // panelBuscarSocio
            // 
            this.panelBuscarSocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.panelBuscarSocio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBuscarSocio.Controls.Add(this.label20);
            this.panelBuscarSocio.Controls.Add(this.label13);
            this.panelBuscarSocio.Controls.Add(this.button3);
            this.panelBuscarSocio.Controls.Add(this.textBoxApellido);
            this.panelBuscarSocio.Controls.Add(this.label3);
            this.panelBuscarSocio.Controls.Add(this.textBoxNombre);
            this.panelBuscarSocio.Controls.Add(this.label2);
            this.panelBuscarSocio.Controls.Add(this.textBoxDni);
            this.panelBuscarSocio.Controls.Add(this.label5);
            this.panelBuscarSocio.Location = new System.Drawing.Point(17, 32);
            this.panelBuscarSocio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBuscarSocio.Name = "panelBuscarSocio";
            this.panelBuscarSocio.Size = new System.Drawing.Size(309, 218);
            this.panelBuscarSocio.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.label18.Location = new System.Drawing.Point(396, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 17);
            this.label18.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.label17.Location = new System.Drawing.Point(396, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 17);
            this.label17.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Maroon;
            this.label20.Location = new System.Drawing.Point(228, 25);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 20);
            this.label20.TabIndex = 32;
            this.label20.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.label13.Location = new System.Drawing.Point(253, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 17);
            this.label13.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(139)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::WindowsFormsApp1.Properties.Resources._5c790123003fa702a1d2795b;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(109, 149);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 48);
            this.button3.TabIndex = 14;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Enabled = false;
            this.textBoxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido.Location = new System.Drawing.Point(105, 98);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(179, 22);
            this.textBoxApellido.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(105, 66);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(179, 22);
            this.textBoxNombre.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre ";
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(105, 25);
            this.textBoxDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(115, 22);
            this.textBoxDni.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(59, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dni";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.label15.Location = new System.Drawing.Point(13, 9);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "Buscar Socio :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.label1.Location = new System.Drawing.Point(219, 335);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Listado de Prestamos:";
            // 
            // panelBuscarLibro
            // 
            this.panelBuscarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.panelBuscarLibro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBuscarLibro.Controls.Add(this.label18);
            this.panelBuscarLibro.Controls.Add(this.checkBoxIntercambiar);
            this.panelBuscarLibro.Controls.Add(this.label17);
            this.panelBuscarLibro.Controls.Add(this.label22);
            this.panelBuscarLibro.Controls.Add(this.label21);
            this.panelBuscarLibro.Controls.Add(this.label16);
            this.panelBuscarLibro.Controls.Add(this.label14);
            this.panelBuscarLibro.Controls.Add(this.textBoxEditorial);
            this.panelBuscarLibro.Controls.Add(this.label10);
            this.panelBuscarLibro.Controls.Add(this.textBoxAutor);
            this.panelBuscarLibro.Controls.Add(this.label7);
            this.panelBuscarLibro.Controls.Add(this.button1);
            this.panelBuscarLibro.Controls.Add(this.textBoxTitulo);
            this.panelBuscarLibro.Controls.Add(this.label4);
            this.panelBuscarLibro.Location = new System.Drawing.Point(344, 33);
            this.panelBuscarLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBuscarLibro.Name = "panelBuscarLibro";
            this.panelBuscarLibro.Size = new System.Drawing.Size(428, 218);
            this.panelBuscarLibro.TabIndex = 9;
            // 
            // checkBoxIntercambiar
            // 
            this.checkBoxIntercambiar.AutoSize = true;
            this.checkBoxIntercambiar.Enabled = false;
            this.checkBoxIntercambiar.ForeColor = System.Drawing.Color.White;
            this.checkBoxIntercambiar.Location = new System.Drawing.Point(303, 34);
            this.checkBoxIntercambiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxIntercambiar.Name = "checkBoxIntercambiar";
            this.checkBoxIntercambiar.Size = new System.Drawing.Size(108, 21);
            this.checkBoxIntercambiar.TabIndex = 35;
            this.checkBoxIntercambiar.Text = "Intercambiar";
            this.checkBoxIntercambiar.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.label22.Location = new System.Drawing.Point(40, 146);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 17);
            this.label22.TabIndex = 34;
            this.label22.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.label21.Location = new System.Drawing.Point(402, 67);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 17);
            this.label21.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Maroon;
            this.label16.Location = new System.Drawing.Point(271, 26);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.label14.Location = new System.Drawing.Point(339, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 17);
            this.label14.TabIndex = 16;
            // 
            // textBoxEditorial
            // 
            this.textBoxEditorial.Enabled = false;
            this.textBoxEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditorial.Location = new System.Drawing.Point(81, 102);
            this.textBoxEditorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEditorial.Name = "textBoxEditorial";
            this.textBoxEditorial.Size = new System.Drawing.Size(237, 22);
            this.textBoxEditorial.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(4, 103);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Editorial";
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Enabled = false;
            this.textBoxAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAutor.Location = new System.Drawing.Point(79, 64);
            this.textBoxAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(240, 22);
            this.textBoxAutor.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Autor";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(139)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources._5c790123003fa702a1d2795b;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(144, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(79, 30);
            this.textBoxTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(187, 22);
            this.textBoxTitulo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Libro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(349, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Buscar Libro :";
            // 
            // panelFechas
            // 
            this.panelFechas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.panelFechas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFechas.Controls.Add(this.label23);
            this.panelFechas.Controls.Add(this.label19);
            this.panelFechas.Controls.Add(this.label11);
            this.panelFechas.Controls.Add(this.label9);
            this.panelFechas.Controls.Add(this.label8);
            this.panelFechas.Controls.Add(this.dateTimePicker2);
            this.panelFechas.Controls.Add(this.dateTimePicker1);
            this.panelFechas.Location = new System.Drawing.Point(787, 32);
            this.panelFechas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFechas.Name = "panelFechas";
            this.panelFechas.Size = new System.Drawing.Size(479, 219);
            this.panelFechas.TabIndex = 11;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(150)))), ((int)(((byte)(30)))));
            this.label23.Location = new System.Drawing.Point(75, 171);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(148, 25);
            this.label23.TabIndex = 33;
            this.label23.Text = "Calcular Días:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Maroon;
            this.label19.Location = new System.Drawing.Point(180, 11);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(153, 17);
            this.label19.TabIndex = 32;
            this.label19.Text = "(Prestamo 7 días max.)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(150)))), ((int)(((byte)(30)))));
            this.label11.Location = new System.Drawing.Point(247, 171);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "....";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(-1, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Fecha Devolución";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fecha Entrega";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(153, 101);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(284, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 54);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(788, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Fecha :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.White;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.label24.Location = new System.Drawing.Point(13, 293);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 18);
            this.label24.TabIndex = 18;
            this.label24.Text = "Buscar :";
            // 
            // textBoxConsultar
            // 
            this.textBoxConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConsultar.Location = new System.Drawing.Point(82, 287);
            this.textBoxConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConsultar.Name = "textBoxConsultar";
            this.textBoxConsultar.Size = new System.Drawing.Size(119, 24);
            this.textBoxConsultar.TabIndex = 19;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(89, 340);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 21);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nombre ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 340);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 21);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Titulo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(125)))), ((int)(((byte)(161)))));
            this.buttonConsultar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.buttonConsultar.FlatAppearance.BorderSize = 0;
            this.buttonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.ForeColor = System.Drawing.Color.White;
            this.buttonConsultar.Image = global::WindowsFormsApp1.Properties.Resources._5c790123003fa702a1d2795b2;
            this.buttonConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConsultar.Location = new System.Drawing.Point(13, 544);
            this.buttonConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(188, 59);
            this.buttonConsultar.TabIndex = 25;
            this.buttonConsultar.Text = "Consultar Devoluciones";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // BDevolver
            // 
            this.BDevolver.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BDevolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(125)))), ((int)(((byte)(161)))));
            this.BDevolver.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.BDevolver.FlatAppearance.BorderSize = 0;
            this.BDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDevolver.ForeColor = System.Drawing.Color.White;
            this.BDevolver.Image = global::WindowsFormsApp1.Properties.Resources.return_book__1_;
            this.BDevolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BDevolver.Location = new System.Drawing.Point(13, 476);
            this.BDevolver.Margin = new System.Windows.Forms.Padding(4);
            this.BDevolver.Name = "BDevolver";
            this.BDevolver.Size = new System.Drawing.Size(188, 49);
            this.BDevolver.TabIndex = 24;
            this.BDevolver.Text = "Devolver";
            this.BDevolver.UseVisualStyleBackColor = false;
            this.BDevolver.Click += new System.EventHandler(this.BDevolver_Click);
            // 
            // buttonBuscarNom
            // 
            this.buttonBuscarNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(139)))));
            this.buttonBuscarNom.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.buttonBuscarNom.FlatAppearance.BorderSize = 0;
            this.buttonBuscarNom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarNom.ForeColor = System.Drawing.Color.White;
            this.buttonBuscarNom.Image = global::WindowsFormsApp1.Properties.Resources._5c790123003fa702a1d2795b;
            this.buttonBuscarNom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarNom.Location = new System.Drawing.Point(17, 383);
            this.buttonBuscarNom.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscarNom.Name = "buttonBuscarNom";
            this.buttonBuscarNom.Size = new System.Drawing.Size(184, 49);
            this.buttonBuscarNom.TabIndex = 21;
            this.buttonBuscarNom.Text = "Buscar ";
            this.buttonBuscarNom.UseVisualStyleBackColor = false;
            this.buttonBuscarNom.Click += new System.EventHandler(this.buttonBuscarNom_Click_1);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(132)))), ((int)(((byte)(74)))));
            this.buttonLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.buttonLimpiar.FlatAppearance.BorderSize = 0;
            this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpiar.Image = global::WindowsFormsApp1.Properties.Resources.limpiar1;
            this.buttonLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpiar.Location = new System.Drawing.Point(492, 268);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(188, 49);
            this.buttonLimpiar.TabIndex = 16;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.buttonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Image = global::WindowsFormsApp1.Properties.Resources.Delete_PNG_Clipart;
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminar.Location = new System.Drawing.Point(688, 268);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(188, 49);
            this.buttonEliminar.TabIndex = 15;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(150)))), ((int)(((byte)(30)))));
            this.buttonModificar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.buttonModificar.FlatAppearance.BorderSize = 0;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.ForeColor = System.Drawing.Color.White;
            this.buttonModificar.Image = global::WindowsFormsApp1.Properties.Resources.Change_PNG_Photo;
            this.buttonModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModificar.Location = new System.Drawing.Point(884, 268);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(188, 49);
            this.buttonModificar.TabIndex = 14;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonGrabar
            // 
            this.buttonGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(109)))));
            this.buttonGrabar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.buttonGrabar.FlatAppearance.BorderSize = 0;
            this.buttonGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrabar.ForeColor = System.Drawing.Color.White;
            this.buttonGrabar.Image = global::WindowsFormsApp1.Properties.Resources.Save_Disk_PNG_Images;
            this.buttonGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGrabar.Location = new System.Drawing.Point(1078, 268);
            this.buttonGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGrabar.Name = "buttonGrabar";
            this.buttonGrabar.Size = new System.Drawing.Size(188, 49);
            this.buttonGrabar.TabIndex = 13;
            this.buttonGrabar.Text = "Grabar";
            this.buttonGrabar.UseVisualStyleBackColor = false;
            this.buttonGrabar.Click += new System.EventHandler(this.buttonGrabar_Click);
            // 
            // Prestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 649);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.BDevolver);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonBuscarNom);
            this.Controls.Add(this.textBoxConsultar);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonGrabar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panelFechas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelBuscarLibro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panelBuscarSocio);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Prestamo";
            this.Text = "Prestamo";
            this.Load += new System.EventHandler(this.Prestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelBuscarSocio.ResumeLayout(false);
            this.panelBuscarSocio.PerformLayout();
            this.panelBuscarLibro.ResumeLayout(false);
            this.panelBuscarLibro.PerformLayout();
            this.panelFechas.ResumeLayout(false);
            this.panelFechas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelBuscarSocio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelBuscarLibro;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelFechas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonGrabar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox textBoxEditorial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pres_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soc_Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soc_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soc_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soc_Telef;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lib_Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aut_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pres_Fecha_Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pres_Fech_Dev;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresDet_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pres_Usu_Id;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.CheckBox checkBoxIntercambiar;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBoxConsultar;
        private System.Windows.Forms.Button buttonBuscarNom;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button BDevolver;
        private System.Windows.Forms.Button buttonConsultar;
    }
}

namespace WindowsFormsApp1
{
    partial class ConsultarDevoluciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.Pres_FechaRealDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresDet_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pres_Usu_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonporfechas = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 107);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(300, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 54);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Devoluciones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.libro111;
            this.pictureBox1.Location = new System.Drawing.Point(43, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            this.Pres_FechaRealDev,
            this.PresDet_Cantidad,
            this.stock_total,
            this.Pres_Usu_Id});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.dataGridView1.Location = new System.Drawing.Point(13, 139);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 257);
            this.dataGridView1.TabIndex = 4;
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
            // Pres_FechaRealDev
            // 
            this.Pres_FechaRealDev.HeaderText = "Devolución Registrada";
            this.Pres_FechaRealDev.MinimumWidth = 6;
            this.Pres_FechaRealDev.Name = "Pres_FechaRealDev";
            this.Pres_FechaRealDev.ReadOnly = true;
            this.Pres_FechaRealDev.Width = 125;
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
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.label24.Location = new System.Drawing.Point(61, 421);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 24);
            this.label24.TabIndex = 19;
            this.label24.Text = "Buscar :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(154, 421);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 28);
            this.textBox1.TabIndex = 20;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(154, 457);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 21);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "N°";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(217, 457);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 21);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Dni";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(286, 457);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 21);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Titulo";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.label2.Location = new System.Drawing.Point(569, 421);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Desde:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(662, 418);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(322, 27);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(662, 451);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(322, 27);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(117)))), ((int)(((byte)(144)))));
            this.label3.Location = new System.Drawing.Point(577, 451);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Hasta:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources._611552;
            this.pictureBox2.Location = new System.Drawing.Point(1031, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // buttonporfechas
            // 
            this.buttonporfechas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(139)))));
            this.buttonporfechas.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.buttonporfechas.FlatAppearance.BorderSize = 0;
            this.buttonporfechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonporfechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonporfechas.ForeColor = System.Drawing.Color.White;
            this.buttonporfechas.Image = global::WindowsFormsApp1.Properties.Resources._5c790123003fa702a1d2795b;
            this.buttonporfechas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonporfechas.Location = new System.Drawing.Point(699, 492);
            this.buttonporfechas.Margin = new System.Windows.Forms.Padding(4);
            this.buttonporfechas.Name = "buttonporfechas";
            this.buttonporfechas.Size = new System.Drawing.Size(230, 49);
            this.buttonporfechas.TabIndex = 29;
            this.buttonporfechas.Text = "Buscar x Fechas";
            this.buttonporfechas.UseVisualStyleBackColor = false;
            this.buttonporfechas.Click += new System.EventHandler(this.buttonporfechas_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(139)))));
            this.buttonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Image = global::WindowsFormsApp1.Properties.Resources._5c790123003fa702a1d2795b;
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(175, 492);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(175, 49);
            this.buttonBuscar.TabIndex = 28;
            this.buttonBuscar.Text = "Buscar ";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // ConsultarDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonporfechas);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarDevoluciones";
            this.Load += new System.EventHandler(this.ConsultarDevoluciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonporfechas;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Pres_FechaRealDev;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresDet_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pres_Usu_Id;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
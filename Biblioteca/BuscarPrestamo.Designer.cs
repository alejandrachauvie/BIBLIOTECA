
namespace WindowsFormsApp1
{
    partial class BuscarPrestamo
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pres_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lib_Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aut_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soc_Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soc_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soc_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pres_Fecha_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pres_Fech_Dev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresEs_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(272, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Título :";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(334, 94);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(214, 22);
            this.textBoxBuscar.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(209, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 84;
            this.label1.Text = "Buscar Prestamo :";
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.buttonbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.buttonbuscar.FlatAppearance.BorderSize = 0;
            this.buttonbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbuscar.ForeColor = System.Drawing.Color.White;
            this.buttonbuscar.Image = global::WindowsFormsApp1.Properties.Resources.bus25x25;
            this.buttonbuscar.Location = new System.Drawing.Point(538, 88);
            this.buttonbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(67, 39);
            this.buttonbuscar.TabIndex = 82;
            this.buttonbuscar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonbuscar.UseVisualStyleBackColor = false;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.book_and_magnifying_glass_illustration_in_3d_isometric_style_vector;
            this.pictureBox1.Location = new System.Drawing.Point(39, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pres_Id,
            this.Lib_Titulo,
            this.Aut_Nombre,
            this.Edit_Nombre,
            this.stock_cantidad,
            this.Soc_Dni,
            this.Soc_Apellido,
            this.Soc_Nombre,
            this.Pres_Fecha_Entrega,
            this.Pres_Fech_Dev,
            this.PresEs_Descripcion});
            this.dataGridView1.Location = new System.Drawing.Point(39, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(716, 334);
            this.dataGridView1.TabIndex = 85;
            // 
            // Pres_Id
            // 
            this.Pres_Id.HeaderText = "N° PRESTAMO";
            this.Pres_Id.MinimumWidth = 6;
            this.Pres_Id.Name = "Pres_Id";
            this.Pres_Id.Width = 125;
            // 
            // Lib_Titulo
            // 
            this.Lib_Titulo.HeaderText = "TITULO";
            this.Lib_Titulo.MinimumWidth = 6;
            this.Lib_Titulo.Name = "Lib_Titulo";
            this.Lib_Titulo.Width = 125;
            // 
            // Aut_Nombre
            // 
            this.Aut_Nombre.HeaderText = "AUTOR";
            this.Aut_Nombre.MinimumWidth = 6;
            this.Aut_Nombre.Name = "Aut_Nombre";
            this.Aut_Nombre.Width = 125;
            // 
            // Edit_Nombre
            // 
            this.Edit_Nombre.HeaderText = "EDITORIAL";
            this.Edit_Nombre.MinimumWidth = 6;
            this.Edit_Nombre.Name = "Edit_Nombre";
            this.Edit_Nombre.Width = 125;
            // 
            // stock_cantidad
            // 
            this.stock_cantidad.HeaderText = "CANTIDAD";
            this.stock_cantidad.MinimumWidth = 6;
            this.stock_cantidad.Name = "stock_cantidad";
            this.stock_cantidad.Width = 125;
            // 
            // Soc_Dni
            // 
            this.Soc_Dni.HeaderText = "DNI";
            this.Soc_Dni.MinimumWidth = 6;
            this.Soc_Dni.Name = "Soc_Dni";
            this.Soc_Dni.Width = 125;
            // 
            // Soc_Apellido
            // 
            this.Soc_Apellido.HeaderText = "APELLIDO";
            this.Soc_Apellido.MinimumWidth = 6;
            this.Soc_Apellido.Name = "Soc_Apellido";
            this.Soc_Apellido.Width = 125;
            // 
            // Soc_Nombre
            // 
            this.Soc_Nombre.HeaderText = "NOMBRE";
            this.Soc_Nombre.MinimumWidth = 6;
            this.Soc_Nombre.Name = "Soc_Nombre";
            this.Soc_Nombre.Width = 125;
            // 
            // Pres_Fecha_Entrega
            // 
            this.Pres_Fecha_Entrega.HeaderText = "ENTREGA";
            this.Pres_Fecha_Entrega.MinimumWidth = 6;
            this.Pres_Fecha_Entrega.Name = "Pres_Fecha_Entrega";
            this.Pres_Fecha_Entrega.Width = 125;
            // 
            // Pres_Fech_Dev
            // 
            this.Pres_Fech_Dev.HeaderText = "DEVOLUCIÓN";
            this.Pres_Fech_Dev.MinimumWidth = 6;
            this.Pres_Fech_Dev.Name = "Pres_Fech_Dev";
            this.Pres_Fech_Dev.Width = 125;
            // 
            // PresEs_Descripcion
            // 
            this.PresEs_Descripcion.HeaderText = "ESTADO";
            this.PresEs_Descripcion.MinimumWidth = 6;
            this.PresEs_Descripcion.Name = "PresEs_Descripcion";
            this.PresEs_Descripcion.Width = 125;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.cerrar;
            this.pictureBox3.Location = new System.Drawing.Point(753, 22);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 86;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // BuscarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarPrestamo";
            this.Load += new System.EventHandler(this.BuscarPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pres_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lib_Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aut_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soc_Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soc_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soc_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pres_Fecha_Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pres_Fech_Dev;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresEs_Descripcion;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
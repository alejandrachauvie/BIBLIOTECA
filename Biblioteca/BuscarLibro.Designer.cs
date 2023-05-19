
namespace WindowsFormsApp1
{
    partial class BuscarLibro
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
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Lib_Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lib_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lib_CantHojas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lib_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibEs_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aut_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubic_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Esta_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(376, 94);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(313, 27);
            this.textBoxBuscar.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lib_Titulo,
            this.Lib_Id,
            this.Lib_CantHojas,
            this.Lib_Descripcion,
            this.LibEs_Descripcion,
            this.Aut_Nombre,
            this.Edit_Nombre,
            this.Ubic_Descripcion,
            this.Esta_Descripcion,
            this.stock_Total});
            this.dataGridView1.Location = new System.Drawing.Point(39, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(786, 249);
            this.dataGridView1.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(268, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 72;
            this.label2.Text = " Titulo :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._1022319;
            this.pictureBox1.Location = new System.Drawing.Point(39, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
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
            this.buttonbuscar.Location = new System.Drawing.Point(708, 82);
            this.buttonbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(67, 39);
            this.buttonbuscar.TabIndex = 70;
            this.buttonbuscar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonbuscar.UseVisualStyleBackColor = false;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.cerrar;
            this.pictureBox3.Location = new System.Drawing.Point(867, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 78;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Lib_Titulo
            // 
            this.Lib_Titulo.HeaderText = "TITULO";
            this.Lib_Titulo.MinimumWidth = 6;
            this.Lib_Titulo.Name = "Lib_Titulo";
            this.Lib_Titulo.Width = 125;
            // 
            // Lib_Id
            // 
            this.Lib_Id.HeaderText = "ID";
            this.Lib_Id.MinimumWidth = 6;
            this.Lib_Id.Name = "Lib_Id";
            this.Lib_Id.Width = 125;
            // 
            // Lib_CantHojas
            // 
            this.Lib_CantHojas.HeaderText = "PÁGINAS";
            this.Lib_CantHojas.MinimumWidth = 6;
            this.Lib_CantHojas.Name = "Lib_CantHojas";
            this.Lib_CantHojas.Width = 125;
            // 
            // Lib_Descripcion
            // 
            this.Lib_Descripcion.HeaderText = "DESCRIPCIÓN";
            this.Lib_Descripcion.MinimumWidth = 6;
            this.Lib_Descripcion.Name = "Lib_Descripcion";
            this.Lib_Descripcion.Width = 125;
            // 
            // LibEs_Descripcion
            // 
            this.LibEs_Descripcion.HeaderText = "ESTADO";
            this.LibEs_Descripcion.MinimumWidth = 6;
            this.LibEs_Descripcion.Name = "LibEs_Descripcion";
            this.LibEs_Descripcion.Width = 125;
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
            // Ubic_Descripcion
            // 
            this.Ubic_Descripcion.HeaderText = "ÚBICACION";
            this.Ubic_Descripcion.MinimumWidth = 6;
            this.Ubic_Descripcion.Name = "Ubic_Descripcion";
            this.Ubic_Descripcion.Width = 125;
            // 
            // Esta_Descripcion
            // 
            this.Esta_Descripcion.HeaderText = "ESTANTE";
            this.Esta_Descripcion.MinimumWidth = 6;
            this.Esta_Descripcion.Name = "Esta_Descripcion";
            this.Esta_Descripcion.Width = 125;
            // 
            // stock_Total
            // 
            this.stock_Total.HeaderText = "STOCK";
            this.stock_Total.MinimumWidth = 6;
            this.stock_Total.Name = "stock_Total";
            this.stock_Total.Width = 125;
            // 
            // BuscarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(904, 509);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarLibro";
            this.Load += new System.EventHandler(this.BuscarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lib_Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lib_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lib_CantHojas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lib_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibEs_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aut_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubic_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Esta_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_Total;
    }
}

namespace WindowsFormsApp1
{
    partial class BuscarSocio
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Soc_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soc_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soc_Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soc_Telef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dom_Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dom_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dom_Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dom_Apto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prov_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InscDet_Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InscEs_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._235231;
            this.pictureBox1.Location = new System.Drawing.Point(48, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.cerrar;
            this.pictureBox3.Location = new System.Drawing.Point(763, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 76;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(214, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 80;
            this.label2.Text = "Apellido :";
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
            this.buttonbuscar.Location = new System.Drawing.Point(654, 70);
            this.buttonbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(67, 39);
            this.buttonbuscar.TabIndex = 79;
            this.buttonbuscar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonbuscar.UseVisualStyleBackColor = false;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(322, 82);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(313, 27);
            this.textBoxBuscar.TabIndex = 78;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Soc_Apellido,
            this.Soc_Nombre,
            this.Soc_Dni,
            this.Soc_Telef,
            this.Dom_Calle,
            this.Dom_Numero,
            this.Dom_Piso,
            this.Dom_Apto,
            this.Local_Nombre,
            this.Prov_Nombre,
            this.Pais_Nombre,
            this.InscDet_Monto,
            this.InscEs_Descripcion});
            this.dataGridView1.Location = new System.Drawing.Point(48, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(684, 310);
            this.dataGridView1.TabIndex = 81;
            // 
            // Soc_Apellido
            // 
            this.Soc_Apellido.HeaderText = "Apellido";
            this.Soc_Apellido.MinimumWidth = 6;
            this.Soc_Apellido.Name = "Soc_Apellido";
            this.Soc_Apellido.Width = 125;
            // 
            // Soc_Nombre
            // 
            this.Soc_Nombre.HeaderText = "Nombre";
            this.Soc_Nombre.MinimumWidth = 6;
            this.Soc_Nombre.Name = "Soc_Nombre";
            this.Soc_Nombre.Width = 125;
            // 
            // Soc_Dni
            // 
            this.Soc_Dni.HeaderText = "Dni";
            this.Soc_Dni.MinimumWidth = 6;
            this.Soc_Dni.Name = "Soc_Dni";
            this.Soc_Dni.Width = 125;
            // 
            // Soc_Telef
            // 
            this.Soc_Telef.HeaderText = "Teléfono";
            this.Soc_Telef.MinimumWidth = 6;
            this.Soc_Telef.Name = "Soc_Telef";
            this.Soc_Telef.Width = 125;
            // 
            // Dom_Calle
            // 
            this.Dom_Calle.HeaderText = "Domicilio";
            this.Dom_Calle.MinimumWidth = 6;
            this.Dom_Calle.Name = "Dom_Calle";
            this.Dom_Calle.Width = 125;
            // 
            // Dom_Numero
            // 
            this.Dom_Numero.HeaderText = "Número";
            this.Dom_Numero.MinimumWidth = 6;
            this.Dom_Numero.Name = "Dom_Numero";
            this.Dom_Numero.Width = 125;
            // 
            // Dom_Piso
            // 
            this.Dom_Piso.HeaderText = "Piso";
            this.Dom_Piso.MinimumWidth = 6;
            this.Dom_Piso.Name = "Dom_Piso";
            this.Dom_Piso.Width = 125;
            // 
            // Dom_Apto
            // 
            this.Dom_Apto.HeaderText = "Apto";
            this.Dom_Apto.MinimumWidth = 6;
            this.Dom_Apto.Name = "Dom_Apto";
            this.Dom_Apto.Width = 125;
            // 
            // Local_Nombre
            // 
            this.Local_Nombre.HeaderText = "Localidad";
            this.Local_Nombre.MinimumWidth = 6;
            this.Local_Nombre.Name = "Local_Nombre";
            this.Local_Nombre.Width = 125;
            // 
            // Prov_Nombre
            // 
            this.Prov_Nombre.HeaderText = "Provincia";
            this.Prov_Nombre.MinimumWidth = 6;
            this.Prov_Nombre.Name = "Prov_Nombre";
            this.Prov_Nombre.Width = 125;
            // 
            // Pais_Nombre
            // 
            this.Pais_Nombre.HeaderText = "País";
            this.Pais_Nombre.MinimumWidth = 6;
            this.Pais_Nombre.Name = "Pais_Nombre";
            this.Pais_Nombre.Width = 125;
            // 
            // InscDet_Monto
            // 
            this.InscDet_Monto.HeaderText = "Matrícula";
            this.InscDet_Monto.MinimumWidth = 6;
            this.InscDet_Monto.Name = "InscDet_Monto";
            this.InscDet_Monto.Width = 125;
            // 
            // InscEs_Descripcion
            // 
            this.InscEs_Descripcion.HeaderText = "Estado";
            this.InscEs_Descripcion.MinimumWidth = 6;
            this.InscEs_Descripcion.Name = "InscEs_Descripcion";
            this.InscEs_Descripcion.Width = 125;
            // 
            // BuscarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarSocio";
            this.Load += new System.EventHandler(this.BuscarSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soc_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soc_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soc_Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soc_Telef;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dom_Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dom_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dom_Piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dom_Apto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prov_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn InscDet_Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn InscEs_Descripcion;
    }
}
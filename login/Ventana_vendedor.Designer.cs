namespace login
{
    partial class Ventana_vendedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_vendedor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncarga = new System.Windows.Forms.PictureBox();
            this.btngrafica = new System.Windows.Forms.PictureBox();
            this.btneliminar = new System.Windows.Forms.PictureBox();
            this.btnagregar = new System.Windows.Forms.PictureBox();
            this.btnmodificar = new System.Windows.Forms.PictureBox();
            this.btnsalir = new System.Windows.Forms.PictureBox();
            this.btnvendedor = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btngrafica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnagregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmodificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnvendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tabla);
            this.groupBox1.Location = new System.Drawing.Point(189, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1054, 674);
            this.groupBox1.TabIndex = 155;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabla de Vendedores";
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToOrderColumns = true;
            this.tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla.BackgroundColor = System.Drawing.Color.DimGray;
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Modificar,
            this.Column11});
            this.tabla.Location = new System.Drawing.Point(6, 25);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.Size = new System.Drawing.Size(1042, 643);
            this.tabla.TabIndex = 188;
            this.tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellClick);
            this.tabla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellDoubleClick);
            this.tabla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabla_KeyPress);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Materno";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Paterno";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Direccion";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Localidad";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Telefono";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Sueldo";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Ruta";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Sucursal";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Modificar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            this.Modificar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Modificar.Text = "Mod";
            this.Modificar.Width = 50;
            // 
            // Column11
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Column11.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column11.HeaderText = "";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 31);
            this.label4.TabIndex = 241;
            this.label4.Text = "Vendedores";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 400);
            this.groupBox2.TabIndex = 240;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btncarga);
            this.panel1.Controls.Add(this.btngrafica);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.btnagregar);
            this.panel1.Controls.Add(this.btnmodificar);
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 373);
            this.panel1.TabIndex = 158;
            // 
            // btncarga
            // 
            this.btncarga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncarga.Image = ((System.Drawing.Image)(resources.GetObject("btncarga.Image")));
            this.btncarga.Location = new System.Drawing.Point(15, 427);
            this.btncarga.Name = "btncarga";
            this.btncarga.Size = new System.Drawing.Size(100, 100);
            this.btncarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncarga.TabIndex = 159;
            this.btncarga.TabStop = false;
            this.btncarga.Click += new System.EventHandler(this.btncarga_Click);
            // 
            // btngrafica
            // 
            this.btngrafica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngrafica.Image = ((System.Drawing.Image)(resources.GetObject("btngrafica.Image")));
            this.btngrafica.Location = new System.Drawing.Point(15, 321);
            this.btngrafica.Name = "btngrafica";
            this.btngrafica.Size = new System.Drawing.Size(100, 100);
            this.btngrafica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btngrafica.TabIndex = 158;
            this.btngrafica.TabStop = false;
            this.btngrafica.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(15, 215);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(100, 100);
            this.btneliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btneliminar.TabIndex = 157;
            this.btneliminar.TabStop = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            this.btneliminar.MouseEnter += new System.EventHandler(this.btneliminar_MouseEnter);
            this.btneliminar.MouseLeave += new System.EventHandler(this.btneliminar_MouseLeave);
            // 
            // btnagregar
            // 
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar.Image")));
            this.btnagregar.Location = new System.Drawing.Point(15, 3);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(100, 100);
            this.btnagregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnagregar.TabIndex = 152;
            this.btnagregar.TabStop = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click_1);
            this.btnagregar.MouseEnter += new System.EventHandler(this.btnagregar_MouseEnter_1);
            this.btnagregar.MouseLeave += new System.EventHandler(this.btnagregar_MouseLeave_1);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.Location = new System.Drawing.Point(15, 109);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(100, 100);
            this.btnmodificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnmodificar.TabIndex = 156;
            this.btnmodificar.TabStop = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            this.btnmodificar.MouseEnter += new System.EventHandler(this.btnmodificar_MouseEnter);
            this.btnmodificar.MouseLeave += new System.EventHandler(this.btnmodificar_MouseLeave);
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(10, 618);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(80, 80);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnsalir.TabIndex = 151;
            this.btnsalir.TabStop = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            this.btnsalir.MouseEnter += new System.EventHandler(this.btnsalir_MouseEnter);
            this.btnsalir.MouseLeave += new System.EventHandler(this.btnsalir_MouseLeave);
            // 
            // btnvendedor
            // 
            this.btnvendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvendedor.Image = ((System.Drawing.Image)(resources.GetObject("btnvendedor.Image")));
            this.btnvendedor.Location = new System.Drawing.Point(11, 12);
            this.btnvendedor.Name = "btnvendedor";
            this.btnvendedor.Size = new System.Drawing.Size(150, 150);
            this.btnvendedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnvendedor.TabIndex = 66;
            this.btnvendedor.TabStop = false;
            // 
            // Ventana_vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1255, 710);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnvendedor);
            this.Name = "Ventana_vendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ventana_vendedor_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btngrafica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnagregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmodificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnvendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnvendedor;
        private System.Windows.Forms.PictureBox btnsalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btngrafica;
        private System.Windows.Forms.PictureBox btneliminar;
        private System.Windows.Forms.PictureBox btnagregar;
        private System.Windows.Forms.PictureBox btnmodificar;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Column11;
        private System.Windows.Forms.PictureBox btncarga;
    }
}
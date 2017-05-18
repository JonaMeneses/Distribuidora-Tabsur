namespace login
{
    partial class menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabla_venta = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabla_productos = new System.Windows.Forms.DataGridView();
            this.tabla_clientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnpedidos = new System.Windows.Forms.PictureBox();
            this.btncaja = new System.Windows.Forms.PictureBox();
            this.btnrutas = new System.Windows.Forms.PictureBox();
            this.btnalmcen = new System.Windows.Forms.PictureBox();
            this.btnVentas = new System.Windows.Forms.PictureBox();
            this.btnpagos = new System.Windows.Forms.PictureBox();
            this.btnvendedor = new System.Windows.Forms.PictureBox();
            this.btnclientes = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_venta)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_clientes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnpedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnalmcen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnpagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnvendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabla_venta
            // 
            this.tabla_venta.AllowUserToAddRows = false;
            this.tabla_venta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabla_venta.BackgroundColor = System.Drawing.Color.DimGray;
            this.tabla_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_venta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6});
            this.tabla_venta.Location = new System.Drawing.Point(6, 57);
            this.tabla_venta.Name = "tabla_venta";
            this.tabla_venta.Size = new System.Drawing.Size(569, 302);
            this.tabla_venta.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tabla_productos);
            this.groupBox1.Controls.Add(this.tabla_clientes);
            this.groupBox1.Controls.Add(this.tabla_venta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1185, 365);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas del Dia";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(945, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Productos";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(597, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Visitas a clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ventas del dia";
            // 
            // tabla_productos
            // 
            this.tabla_productos.AllowUserToAddRows = false;
            this.tabla_productos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla_productos.BackgroundColor = System.Drawing.Color.DimGray;
            this.tabla_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.dataGridViewTextBoxColumn2,
            this.Column9,
            this.dataGridViewImageColumn1,
            this.dataGridViewButtonColumn2});
            this.tabla_productos.Location = new System.Drawing.Point(867, 57);
            this.tabla_productos.Name = "tabla_productos";
            this.tabla_productos.Size = new System.Drawing.Size(312, 302);
            this.tabla_productos.TabIndex = 2;
            // 
            // tabla_clientes
            // 
            this.tabla_clientes.AllowUserToAddRows = false;
            this.tabla_clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla_clientes.BackgroundColor = System.Drawing.Color.DimGray;
            this.tabla_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.Column8,
            this.Column11,
            this.Column7,
            this.dataGridViewButtonColumn1});
            this.tabla_clientes.Location = new System.Drawing.Point(581, 57);
            this.tabla_clientes.Name = "tabla_clientes";
            this.tabla_clientes.Size = new System.Drawing.Size(280, 302);
            this.tabla_clientes.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ID cliente";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Nombre cliente";
            this.Column8.Name = "Column8";
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column11.HeaderText = "Apellido";
            this.Column11.Name = "Column11";
            this.Column11.Width = 83;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "";
            this.Column7.Name = "Column7";
            this.Column7.Width = 25;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Width = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnpedidos);
            this.panel1.Controls.Add(this.btncaja);
            this.panel1.Controls.Add(this.btnrutas);
            this.panel1.Controls.Add(this.btnalmcen);
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Controls.Add(this.btnpagos);
            this.panel1.Controls.Add(this.btnvendedor);
            this.panel1.Controls.Add(this.btnclientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 185);
            this.panel1.TabIndex = 8;
            // 
            // btnpedidos
            // 
            this.btnpedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnpedidos.Image")));
            this.btnpedidos.Location = new System.Drawing.Point(1392, 3);
            this.btnpedidos.Name = "btnpedidos";
            this.btnpedidos.Size = new System.Drawing.Size(151, 150);
            this.btnpedidos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnpedidos.TabIndex = 8;
            this.btnpedidos.TabStop = false;
            this.btnpedidos.Click += new System.EventHandler(this.btnpedidos_Click);
            // 
            // btncaja
            // 
            this.btncaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncaja.Image = ((System.Drawing.Image)(resources.GetObject("btncaja.Image")));
            this.btncaja.Location = new System.Drawing.Point(1025, 0);
            this.btncaja.Name = "btncaja";
            this.btncaja.Size = new System.Drawing.Size(151, 150);
            this.btncaja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncaja.TabIndex = 7;
            this.btncaja.TabStop = false;
            this.btncaja.Click += new System.EventHandler(this.btncaja_Click);
            // 
            // btnrutas
            // 
            this.btnrutas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrutas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrutas.Image = ((System.Drawing.Image)(resources.GetObject("btnrutas.Image")));
            this.btnrutas.Location = new System.Drawing.Point(854, 0);
            this.btnrutas.Name = "btnrutas";
            this.btnrutas.Size = new System.Drawing.Size(151, 150);
            this.btnrutas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnrutas.TabIndex = 6;
            this.btnrutas.TabStop = false;
            this.btnrutas.Click += new System.EventHandler(this.btnsucursal_Click);
            this.btnrutas.MouseEnter += new System.EventHandler(this.btnsucursal_MouseEnter);
            this.btnrutas.MouseLeave += new System.EventHandler(this.btnsucursal_MouseLeave);
            // 
            // btnalmcen
            // 
            this.btnalmcen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnalmcen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnalmcen.Image = ((System.Drawing.Image)(resources.GetObject("btnalmcen.Image")));
            this.btnalmcen.Location = new System.Drawing.Point(687, 3);
            this.btnalmcen.Name = "btnalmcen";
            this.btnalmcen.Size = new System.Drawing.Size(151, 150);
            this.btnalmcen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnalmcen.TabIndex = 3;
            this.btnalmcen.TabStop = false;
            this.btnalmcen.Click += new System.EventHandler(this.btnalmcen_Click);
            this.btnalmcen.MouseEnter += new System.EventHandler(this.btnalmcen_MouseEnter);
            this.btnalmcen.MouseLeave += new System.EventHandler(this.btnalmcen_MouseLeave);
            // 
            // btnVentas
            // 
            this.btnVentas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.Location = new System.Drawing.Point(516, 0);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(151, 150);
            this.btnVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVentas.TabIndex = 5;
            this.btnVentas.TabStop = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            this.btnVentas.MouseEnter += new System.EventHandler(this.btnVentas_MouseEnter);
            this.btnVentas.MouseLeave += new System.EventHandler(this.btnVentas_MouseLeave);
            // 
            // btnpagos
            // 
            this.btnpagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpagos.Image = ((System.Drawing.Image)(resources.GetObject("btnpagos.Image")));
            this.btnpagos.Location = new System.Drawing.Point(341, 0);
            this.btnpagos.Name = "btnpagos";
            this.btnpagos.Size = new System.Drawing.Size(151, 150);
            this.btnpagos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnpagos.TabIndex = 4;
            this.btnpagos.TabStop = false;
            this.btnpagos.Click += new System.EventHandler(this.btnpagos_Click);
            this.btnpagos.MouseEnter += new System.EventHandler(this.btnCredito_MouseEnter);
            this.btnpagos.MouseLeave += new System.EventHandler(this.btnCredito_MouseLeave);
            // 
            // btnvendedor
            // 
            this.btnvendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvendedor.Image = ((System.Drawing.Image)(resources.GetObject("btnvendedor.Image")));
            this.btnvendedor.Location = new System.Drawing.Point(8, 0);
            this.btnvendedor.Name = "btnvendedor";
            this.btnvendedor.Size = new System.Drawing.Size(151, 150);
            this.btnvendedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnvendedor.TabIndex = 1;
            this.btnvendedor.TabStop = false;
            this.btnvendedor.Click += new System.EventHandler(this.btnvendedor_Click);
            this.btnvendedor.MouseEnter += new System.EventHandler(this.btnvendedor_MouseEnter);
            this.btnvendedor.MouseLeave += new System.EventHandler(this.btnvendedor_MouseLeave);
            // 
            // btnclientes
            // 
            this.btnclientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclientes.Image = ((System.Drawing.Image)(resources.GetObject("btnclientes.Image")));
            this.btnclientes.Location = new System.Drawing.Point(174, 0);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(151, 150);
            this.btnclientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnclientes.TabIndex = 2;
            this.btnclientes.TabStop = false;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            this.btnclientes.DragLeave += new System.EventHandler(this.btnclientes_DragLeave);
            this.btnclientes.MouseEnter += new System.EventHandler(this.btnclientes_MouseEnter);
            this.btnclientes.MouseLeave += new System.EventHandler(this.btnclientes_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1185, 206);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registros";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID venta";
            this.ID.Name = "ID";
            this.ID.Width = 75;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.Width = 71;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID vendedor";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre vendedor";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID cliente";
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre cliente";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Column6.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            this.Column6.Width = 40;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Existencia";
            this.Column9.Name = "Column9";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 25;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewButtonColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Visible = false;
            this.dataGridViewButtonColumn2.Width = 40;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1237, 601);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_FormClosing);
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_venta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_clientes)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnpedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnalmcen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnpagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnvendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_venta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btncaja;
        private System.Windows.Forms.PictureBox btnrutas;
        private System.Windows.Forms.PictureBox btnalmcen;
        private System.Windows.Forms.PictureBox btnVentas;
        private System.Windows.Forms.PictureBox btnpagos;
        private System.Windows.Forms.PictureBox btnvendedor;
        private System.Windows.Forms.PictureBox btnclientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox btnpedidos;
        private System.Windows.Forms.DataGridView tabla_productos;
        private System.Windows.Forms.DataGridView tabla_clientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
    }
}
namespace login
{
    partial class Ventana_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_cliente));
            this.btnvendedor = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btngrafica = new System.Windows.Forms.PictureBox();
            this.btneliminar = new System.Windows.Forms.PictureBox();
            this.btnagregar = new System.Windows.Forms.PictureBox();
            this.btnmodificar = new System.Windows.Forms.PictureBox();
            this.btnsalir = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnvendedor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btngrafica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnagregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmodificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvendedor
            // 
            this.btnvendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvendedor.Image = ((System.Drawing.Image)(resources.GetObject("btnvendedor.Image")));
            this.btnvendedor.Location = new System.Drawing.Point(12, 21);
            this.btnvendedor.Name = "btnvendedor";
            this.btnvendedor.Size = new System.Drawing.Size(150, 150);
            this.btnvendedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnvendedor.TabIndex = 60;
            this.btnvendedor.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tabla);
            this.groupBox1.Location = new System.Drawing.Point(168, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 645);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabla de Clientes";
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AllowUserToOrderColumns = true;
            this.tabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla.BackgroundColor = System.Drawing.Color.DimGray;
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.paterno,
            this.Materno,
            this.Direccion,
            this.Referencias,
            this.Localidad,
            this.Colonia,
            this.Estado,
            this.Column2,
            this.Limite,
            this.Column1});
            this.tabla.Location = new System.Drawing.Point(6, 19);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.Size = new System.Drawing.Size(1005, 620);
            this.tabla.TabIndex = 17;
            this.tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellClick);
            this.tabla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellDoubleClick);
            this.tabla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabla_KeyPress);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 45;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // paterno
            // 
            this.paterno.HeaderText = "Paterno";
            this.paterno.Name = "paterno";
            this.paterno.ReadOnly = true;
            // 
            // Materno
            // 
            this.Materno.HeaderText = "Materno";
            this.Materno.Name = "Materno";
            this.Materno.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Referencias
            // 
            this.Referencias.HeaderText = "Referencias";
            this.Referencias.Name = "Referencias";
            this.Referencias.ReadOnly = true;
            // 
            // Localidad
            // 
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            // 
            // Colonia
            // 
            this.Colonia.HeaderText = "Colonia";
            this.Colonia.Name = "Colonia";
            this.Colonia.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Telefono";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Limite
            // 
            this.Limite.HeaderText = "Limite credito";
            this.Limite.Name = "Limite";
            this.Limite.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 400);
            this.groupBox2.TabIndex = 241;
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
            this.panel1.Controls.Add(this.btngrafica);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.btnagregar);
            this.panel1.Controls.Add(this.btnmodificar);
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 373);
            this.panel1.TabIndex = 158;
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
            this.btngrafica.Click += new System.EventHandler(this.btngrafica_Click);
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
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            this.btnagregar.MouseEnter += new System.EventHandler(this.btnagregar_MouseEnter);
            this.btnagregar.MouseLeave += new System.EventHandler(this.btnagregar_MouseLeave);
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
            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(12, 614);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(80, 80);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnsalir.TabIndex = 242;
            this.btnsalir.TabStop = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            this.btnsalir.MouseEnter += new System.EventHandler(this.btnsalir_MouseEnter);
            this.btnsalir.MouseLeave += new System.EventHandler(this.btnsalir_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 37);
            this.label4.TabIndex = 243;
            this.label4.Text = "Clientes";
            // 
            // Ventana_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1197, 697);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnvendedor);
            this.Name = "Ventana_cliente";
            this.Text = "Ventana_cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ventana_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnvendedor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btngrafica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnagregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmodificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnvendedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btngrafica;
        private System.Windows.Forms.PictureBox btneliminar;
        private System.Windows.Forms.PictureBox btnagregar;
        private System.Windows.Forms.PictureBox btnmodificar;
        private System.Windows.Forms.PictureBox btnsalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}
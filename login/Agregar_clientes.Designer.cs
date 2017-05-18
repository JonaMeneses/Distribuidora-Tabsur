namespace login
{
    partial class Agregar_clientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_clientes));
            this.txtestado = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtsecuencia = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtlocal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcolonia = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txttipolocal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtreferencias = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnvendedor = new System.Windows.Forms.PictureBox();
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
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite_credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_visita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Secuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtvendedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlocalidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaterno = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtlimite = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.PictureBox();
            this.btnsalir = new System.Windows.Forms.PictureBox();
            this.btneliminar = new System.Windows.Forms.PictureBox();
            this.btnmodificar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnvendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnagregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmodificar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtestado
            // 
            this.txtestado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestado.FormattingEnabled = true;
            this.txtestado.Items.AddRange(new object[] {
            "Visitado",
            "No Visitado"});
            this.txtestado.Location = new System.Drawing.Point(908, 127);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(223, 24);
            this.txtestado.TabIndex = 11;
            this.txtestado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_lectura);
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(431, 62);
            this.txtnombre.MaxLength = 30;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(223, 26);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 134;
            this.label1.Text = "Nombre";
            // 
            // txtfecha
            // 
            this.txtfecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.Location = new System.Drawing.Point(908, 222);
            this.txtfecha.MaxLength = 10;
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(223, 26);
            this.txtfecha.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(701, 221);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 25);
            this.label20.TabIndex = 129;
            this.label20.Text = "Dias de Visita";
            // 
            // txtsecuencia
            // 
            this.txtsecuencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsecuencia.BackColor = System.Drawing.SystemColors.Window;
            this.txtsecuencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsecuencia.Location = new System.Drawing.Point(908, 190);
            this.txtsecuencia.MaxLength = 3;
            this.txtsecuencia.Name = "txtsecuencia";
            this.txtsecuencia.Size = new System.Drawing.Size(223, 26);
            this.txtsecuencia.TabIndex = 13;
            this.txtsecuencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsecuencia_KeyPress);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(700, 189);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 25);
            this.label22.TabIndex = 125;
            this.label22.Text = "Secuencia";
            // 
            // txtlocal
            // 
            this.txtlocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocal.Location = new System.Drawing.Point(431, 255);
            this.txtlocal.MaxLength = 30;
            this.txtlocal.Name = "txtlocal";
            this.txtlocal.Size = new System.Drawing.Size(223, 26);
            this.txtlocal.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(245, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 25);
            this.label14.TabIndex = 120;
            this.label14.Text = "Nombre De Local";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(431, 222);
            this.txtdireccion.MaxLength = 50;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(223, 26);
            this.txtdireccion.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(245, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 25);
            this.label15.TabIndex = 118;
            this.label15.Text = "Direccion";
            // 
            // txtcolonia
            // 
            this.txtcolonia.BackColor = System.Drawing.SystemColors.Window;
            this.txtcolonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcolonia.Location = new System.Drawing.Point(431, 190);
            this.txtcolonia.MaxLength = 30;
            this.txtcolonia.Name = "txtcolonia";
            this.txtcolonia.Size = new System.Drawing.Size(223, 26);
            this.txtcolonia.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(245, 189);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 25);
            this.label16.TabIndex = 116;
            this.label16.Text = "Colonia";
            // 
            // txttipolocal
            // 
            this.txttipolocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttipolocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipolocal.Location = new System.Drawing.Point(908, 158);
            this.txttipolocal.MaxLength = 15;
            this.txttipolocal.Name = "txttipolocal";
            this.txttipolocal.Size = new System.Drawing.Size(223, 26);
            this.txttipolocal.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(701, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 111;
            this.label8.Text = "Tipo Local";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(701, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 110;
            this.label9.Text = "Estado";
            // 
            // txtreferencias
            // 
            this.txtreferencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtreferencias.BackColor = System.Drawing.SystemColors.Window;
            this.txtreferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreferencias.Location = new System.Drawing.Point(908, 94);
            this.txtreferencias.MaxLength = 30;
            this.txtreferencias.Name = "txtreferencias";
            this.txtreferencias.Size = new System.Drawing.Size(223, 26);
            this.txtreferencias.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(703, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 25);
            this.label10.TabIndex = 108;
            this.label10.Text = "Referencias";
            // 
            // btnvendedor
            // 
            this.btnvendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvendedor.Image = ((System.Drawing.Image)(resources.GetObject("btnvendedor.Image")));
            this.btnvendedor.Location = new System.Drawing.Point(7, 30);
            this.btnvendedor.Name = "btnvendedor";
            this.btnvendedor.Size = new System.Drawing.Size(223, 216);
            this.btnvendedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnvendedor.TabIndex = 107;
            this.btnvendedor.TabStop = false;
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
            this.Telefono,
            this.Limite_credito,
            this.Nombre_local,
            this.Fecha_visita,
            this.Secuencia,
            this.Tipo_local,
            this.vendedor});
            this.tabla.Location = new System.Drawing.Point(7, 306);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.Size = new System.Drawing.Size(1124, 323);
            this.tabla.TabIndex = 16;
            this.tabla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellDoubleClick);
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
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Limite_credito
            // 
            this.Limite_credito.HeaderText = "Limite Credito";
            this.Limite_credito.Name = "Limite_credito";
            this.Limite_credito.ReadOnly = true;
            this.Limite_credito.Width = 60;
            // 
            // Nombre_local
            // 
            this.Nombre_local.HeaderText = "Nombre local";
            this.Nombre_local.Name = "Nombre_local";
            this.Nombre_local.ReadOnly = true;
            // 
            // Fecha_visita
            // 
            this.Fecha_visita.HeaderText = "Dia Visita";
            this.Fecha_visita.Name = "Fecha_visita";
            this.Fecha_visita.ReadOnly = true;
            // 
            // Secuencia
            // 
            this.Secuencia.HeaderText = "Secuencia";
            this.Secuencia.Name = "Secuencia";
            this.Secuencia.ReadOnly = true;
            // 
            // Tipo_local
            // 
            this.Tipo_local.HeaderText = "Tipo local";
            this.Tipo_local.Name = "Tipo_local";
            this.Tipo_local.ReadOnly = true;
            // 
            // vendedor
            // 
            this.vendedor.HeaderText = "Vendedor";
            this.vendedor.Name = "vendedor";
            this.vendedor.ReadOnly = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(664, 213);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(36, 35);
            this.btnLimpiar.TabIndex = 101;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtvendedor
            // 
            this.txtvendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtvendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvendedor.FormattingEnabled = true;
            this.txtvendedor.Location = new System.Drawing.Point(908, 255);
            this.txtvendedor.Name = "txtvendedor";
            this.txtvendedor.Size = new System.Drawing.Size(223, 24);
            this.txtvendedor.TabIndex = 15;
            this.txtvendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_lectura);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(700, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 25);
            this.label5.TabIndex = 99;
            this.label5.Text = "Vendedor asignado";
            // 
            // txtlocalidad
            // 
            this.txtlocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocalidad.Location = new System.Drawing.Point(431, 158);
            this.txtlocalidad.MaxLength = 50;
            this.txtlocalidad.Name = "txtlocalidad";
            this.txtlocalidad.Size = new System.Drawing.Size(223, 26);
            this.txtlocalidad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 93;
            this.label3.Text = "Localidad";
            // 
            // txtpaterno
            // 
            this.txtpaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaterno.Location = new System.Drawing.Point(431, 94);
            this.txtpaterno.MaxLength = 30;
            this.txtpaterno.Name = "txtpaterno";
            this.txtpaterno.Size = new System.Drawing.Size(223, 26);
            this.txtpaterno.TabIndex = 2;
            this.txtpaterno.TextChanged += new System.EventHandler(this.txtpaterno_TextChanged);
            this.txtpaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpaterno_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 91;
            this.label2.Text = "Paterno";
            // 
            // txtmaterno
            // 
            this.txtmaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaterno.Location = new System.Drawing.Point(431, 126);
            this.txtmaterno.MaxLength = 30;
            this.txtmaterno.Name = "txtmaterno";
            this.txtmaterno.Size = new System.Drawing.Size(223, 26);
            this.txtmaterno.TabIndex = 3;
            this.txtmaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmaterno_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(245, 127);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(91, 25);
            this.label24.TabIndex = 137;
            this.label24.Text = "Materno";
            // 
            // txttelefono
            // 
            this.txttelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(908, 62);
            this.txttelefono.MaxLength = 15;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(223, 26);
            this.txttelefono.TabIndex = 9;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(700, 61);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 25);
            this.label21.TabIndex = 140;
            this.label21.Text = "Telefono";
            // 
            // txtlimite
            // 
            this.txtlimite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlimite.Location = new System.Drawing.Point(908, 30);
            this.txtlimite.MaxLength = 10;
            this.txtlimite.Name = "txtlimite";
            this.txtlimite.Size = new System.Drawing.Size(223, 26);
            this.txtlimite.TabIndex = 8;
            this.txtlimite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlimite_KeyPress);
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(700, 32);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(144, 25);
            this.label25.TabIndex = 144;
            this.label25.Text = "Limite Credito";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(431, 30);
            this.txtid.MaxLength = 50;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(223, 26);
            this.txtid.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(245, 31);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 25);
            this.label27.TabIndex = 146;
            this.label27.Text = "ID";
            // 
            // btnagregar
            // 
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar.Image")));
            this.btnagregar.Location = new System.Drawing.Point(3, 3);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(128, 128);
            this.btnagregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnagregar.TabIndex = 148;
            this.btnagregar.TabStop = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            this.btnagregar.MouseEnter += new System.EventHandler(this.btnagregar_MouseEnter);
            this.btnagregar.MouseLeave += new System.EventHandler(this.btnagregar_MouseLeave);
            // 
            // btnsalir
            // 
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(3, 592);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(128, 128);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnsalir.TabIndex = 149;
            this.btnsalir.TabStop = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            this.btnsalir.MouseEnter += new System.EventHandler(this.btnsalir_MouseEnter);
            this.btnsalir.MouseLeave += new System.EventHandler(this.btnsalir_MouseLeave);
            // 
            // btneliminar
            // 
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(3, 299);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(128, 128);
            this.btneliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btneliminar.TabIndex = 150;
            this.btneliminar.TabStop = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            this.btneliminar.MouseEnter += new System.EventHandler(this.btneliminar_MouseEnter);
            this.btneliminar.MouseLeave += new System.EventHandler(this.btneliminar_MouseLeave);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.Location = new System.Drawing.Point(3, 149);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(128, 128);
            this.btnmodificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnmodificar.TabIndex = 151;
            this.btnmodificar.TabStop = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click_1);
            this.btnmodificar.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.btnmodificar.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1162, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 638);
            this.groupBox1.TabIndex = 152;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnmodificar);
            this.panel1.Controls.Add(this.btneliminar);
            this.panel1.Controls.Add(this.btnagregar);
            this.panel1.Location = new System.Drawing.Point(6, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 612);
            this.panel1.TabIndex = 0;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 446);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 152;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.btnvendedor);
            this.groupBox2.Controls.Add(this.txtlimite);
            this.groupBox2.Controls.Add(this.tabla);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.txttelefono);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtmaterno);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.txtestado);
            this.groupBox2.Controls.Add(this.txtnombre);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtfecha);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtsecuencia);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txtlocal);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtdireccion);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtcolonia);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txttipolocal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtreferencias);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.txtvendedor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtlocalidad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtpaterno);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1151, 637);
            this.groupBox2.TabIndex = 153;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 37);
            this.label4.TabIndex = 244;
            this.label4.Text = "Clientes";
            // 
            // Agregar_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1333, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Agregar_clientes";
            this.Text = "Agregar_clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Agregar_clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnvendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnagregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmodificar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox txtestado;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtsecuencia;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtlocal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtcolonia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txttipolocal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtreferencias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox btnvendedor;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox txtvendedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtlocalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaterno;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtlimite;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.PictureBox btnagregar;
        private System.Windows.Forms.PictureBox btnsalir;
        private System.Windows.Forms.PictureBox btneliminar;
        private System.Windows.Forms.PictureBox btnmodificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite_credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_local;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_visita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Secuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_local;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
        private System.Windows.Forms.Timer timer1;
    }
}
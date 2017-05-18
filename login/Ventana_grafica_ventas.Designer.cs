namespace login
{
    partial class Ventana_grafica_ventas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.diciembre = new System.Windows.Forms.RadioButton();
            this.noviembre = new System.Windows.Forms.RadioButton();
            this.octubre = new System.Windows.Forms.RadioButton();
            this.septiembre = new System.Windows.Forms.RadioButton();
            this.agosto = new System.Windows.Forms.RadioButton();
            this.julio = new System.Windows.Forms.RadioButton();
            this.junio = new System.Windows.Forms.RadioButton();
            this.mayo = new System.Windows.Forms.RadioButton();
            this.abril = new System.Windows.Forms.RadioButton();
            this.marzo = new System.Windows.Forms.RadioButton();
            this.febrero = new System.Windows.Forms.RadioButton();
            this.enero = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clientes = new System.Windows.Forms.RadioButton();
            this.vendedores = new System.Windows.Forms.RadioButton();
            this.gastos = new System.Windows.Forms.RadioButton();
            this.ventas = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grafica
            // 
            this.Grafica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grafica.BackColor = System.Drawing.Color.DimGray;
            this.Grafica.BorderlineColor = System.Drawing.Color.Black;
            chartArea8.Name = "ChartArea1";
            this.Grafica.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.Grafica.Legends.Add(legend8);
            this.Grafica.Location = new System.Drawing.Point(-8, 13);
            this.Grafica.Name = "Grafica";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.Grafica.Series.Add(series8);
            this.Grafica.Size = new System.Drawing.Size(956, 642);
            this.Grafica.TabIndex = 0;
            this.Grafica.Text = "chart1";
            this.Grafica.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.diciembre);
            this.panel1.Controls.Add(this.noviembre);
            this.panel1.Controls.Add(this.octubre);
            this.panel1.Controls.Add(this.septiembre);
            this.panel1.Controls.Add(this.agosto);
            this.panel1.Controls.Add(this.julio);
            this.panel1.Controls.Add(this.junio);
            this.panel1.Controls.Add(this.mayo);
            this.panel1.Controls.Add(this.abril);
            this.panel1.Controls.Add(this.marzo);
            this.panel1.Controls.Add(this.febrero);
            this.panel1.Controls.Add(this.enero);
            this.panel1.Location = new System.Drawing.Point(5, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 577);
            this.panel1.TabIndex = 1;
            // 
            // diciembre
            // 
            this.diciembre.AutoSize = true;
            this.diciembre.Location = new System.Drawing.Point(13, 541);
            this.diciembre.Name = "diciembre";
            this.diciembre.Size = new System.Drawing.Size(118, 24);
            this.diciembre.TabIndex = 12;
            this.diciembre.TabStop = true;
            this.diciembre.Text = "DICIEMBRE";
            this.diciembre.UseVisualStyleBackColor = true;
            this.diciembre.CheckedChanged += new System.EventHandler(this.diciembre_CheckedChanged);
            // 
            // noviembre
            // 
            this.noviembre.AutoSize = true;
            this.noviembre.Location = new System.Drawing.Point(12, 496);
            this.noviembre.Name = "noviembre";
            this.noviembre.Size = new System.Drawing.Size(124, 24);
            this.noviembre.TabIndex = 11;
            this.noviembre.TabStop = true;
            this.noviembre.Text = "NOVIEMBRE";
            this.noviembre.UseVisualStyleBackColor = true;
            this.noviembre.CheckedChanged += new System.EventHandler(this.noviembre_CheckedChanged);
            // 
            // octubre
            // 
            this.octubre.AutoSize = true;
            this.octubre.Location = new System.Drawing.Point(12, 446);
            this.octubre.Name = "octubre";
            this.octubre.Size = new System.Drawing.Size(105, 24);
            this.octubre.TabIndex = 10;
            this.octubre.TabStop = true;
            this.octubre.Text = "OCTUBRE";
            this.octubre.UseVisualStyleBackColor = true;
            this.octubre.CheckedChanged += new System.EventHandler(this.octubre_CheckedChanged);
            // 
            // septiembre
            // 
            this.septiembre.AutoSize = true;
            this.septiembre.Location = new System.Drawing.Point(12, 399);
            this.septiembre.Name = "septiembre";
            this.septiembre.Size = new System.Drawing.Size(130, 24);
            this.septiembre.TabIndex = 9;
            this.septiembre.TabStop = true;
            this.septiembre.Text = "SEPTIEMPRE";
            this.septiembre.UseVisualStyleBackColor = true;
            this.septiembre.CheckedChanged += new System.EventHandler(this.septiembre_CheckedChanged);
            // 
            // agosto
            // 
            this.agosto.AutoSize = true;
            this.agosto.Location = new System.Drawing.Point(12, 350);
            this.agosto.Name = "agosto";
            this.agosto.Size = new System.Drawing.Size(95, 24);
            this.agosto.TabIndex = 8;
            this.agosto.TabStop = true;
            this.agosto.Text = "AGOSTO";
            this.agosto.UseVisualStyleBackColor = true;
            this.agosto.CheckedChanged += new System.EventHandler(this.agosto_CheckedChanged);
            // 
            // julio
            // 
            this.julio.AutoSize = true;
            this.julio.Location = new System.Drawing.Point(12, 303);
            this.julio.Name = "julio";
            this.julio.Size = new System.Drawing.Size(73, 24);
            this.julio.TabIndex = 6;
            this.julio.TabStop = true;
            this.julio.Text = "JULIO";
            this.julio.UseVisualStyleBackColor = true;
            this.julio.CheckedChanged += new System.EventHandler(this.julio_CheckedChanged);
            // 
            // junio
            // 
            this.junio.AutoSize = true;
            this.junio.Checked = true;
            this.junio.Location = new System.Drawing.Point(12, 259);
            this.junio.Name = "junio";
            this.junio.Size = new System.Drawing.Size(75, 24);
            this.junio.TabIndex = 5;
            this.junio.TabStop = true;
            this.junio.Text = "JUNIO";
            this.junio.UseVisualStyleBackColor = true;
            this.junio.CheckedChanged += new System.EventHandler(this.junio_CheckedChanged);
            // 
            // mayo
            // 
            this.mayo.AutoSize = true;
            this.mayo.Location = new System.Drawing.Point(12, 208);
            this.mayo.Name = "mayo";
            this.mayo.Size = new System.Drawing.Size(74, 24);
            this.mayo.TabIndex = 4;
            this.mayo.TabStop = true;
            this.mayo.Text = "MAYO";
            this.mayo.UseVisualStyleBackColor = true;
            this.mayo.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // abril
            // 
            this.abril.AutoSize = true;
            this.abril.Location = new System.Drawing.Point(12, 157);
            this.abril.Name = "abril";
            this.abril.Size = new System.Drawing.Size(75, 24);
            this.abril.TabIndex = 3;
            this.abril.TabStop = true;
            this.abril.Text = "ABRIL";
            this.abril.UseVisualStyleBackColor = true;
            this.abril.CheckedChanged += new System.EventHandler(this.abril_CheckedChanged);
            // 
            // marzo
            // 
            this.marzo.AutoSize = true;
            this.marzo.Location = new System.Drawing.Point(12, 108);
            this.marzo.Name = "marzo";
            this.marzo.Size = new System.Drawing.Size(85, 24);
            this.marzo.TabIndex = 2;
            this.marzo.TabStop = true;
            this.marzo.Text = "MARZO";
            this.marzo.UseVisualStyleBackColor = true;
            this.marzo.CheckedChanged += new System.EventHandler(this.marzo_CheckedChanged);
            // 
            // febrero
            // 
            this.febrero.AutoSize = true;
            this.febrero.Location = new System.Drawing.Point(12, 64);
            this.febrero.Name = "febrero";
            this.febrero.Size = new System.Drawing.Size(106, 24);
            this.febrero.TabIndex = 1;
            this.febrero.TabStop = true;
            this.febrero.Text = "FEBRERO";
            this.febrero.UseVisualStyleBackColor = true;
            this.febrero.CheckedChanged += new System.EventHandler(this.febrero_CheckedChanged);
            // 
            // enero
            // 
            this.enero.AutoSize = true;
            this.enero.Location = new System.Drawing.Point(12, 22);
            this.enero.Name = "enero";
            this.enero.Size = new System.Drawing.Size(84, 24);
            this.enero.TabIndex = 0;
            this.enero.TabStop = true;
            this.enero.Text = "ENERO";
            this.enero.UseVisualStyleBackColor = true;
            this.enero.CheckedChanged += new System.EventHandler(this.enero_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1114, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 603);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meses";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(954, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 603);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entidades";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.clientes);
            this.panel2.Controls.Add(this.vendedores);
            this.panel2.Controls.Add(this.gastos);
            this.panel2.Controls.Add(this.ventas);
            this.panel2.Location = new System.Drawing.Point(5, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 577);
            this.panel2.TabIndex = 1;
            // 
            // clientes
            // 
            this.clientes.AutoSize = true;
            this.clientes.Location = new System.Drawing.Point(10, 541);
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(105, 24);
            this.clientes.TabIndex = 3;
            this.clientes.TabStop = true;
            this.clientes.Text = "CLIENTES";
            this.clientes.UseVisualStyleBackColor = true;
            this.clientes.CheckedChanged += new System.EventHandler(this.clientes_CheckedChanged);
            // 
            // vendedores
            // 
            this.vendedores.AutoSize = true;
            this.vendedores.Location = new System.Drawing.Point(10, 350);
            this.vendedores.Name = "vendedores";
            this.vendedores.Size = new System.Drawing.Size(141, 24);
            this.vendedores.TabIndex = 2;
            this.vendedores.TabStop = true;
            this.vendedores.Text = "VENDEDORES";
            this.vendedores.UseVisualStyleBackColor = true;
            this.vendedores.CheckedChanged += new System.EventHandler(this.vendedores_CheckedChanged);
            // 
            // gastos
            // 
            this.gastos.AutoSize = true;
            this.gastos.Location = new System.Drawing.Point(10, 174);
            this.gastos.Name = "gastos";
            this.gastos.Size = new System.Drawing.Size(94, 24);
            this.gastos.TabIndex = 1;
            this.gastos.TabStop = true;
            this.gastos.Text = "GASTOS";
            this.gastos.UseVisualStyleBackColor = true;
            this.gastos.CheckedChanged += new System.EventHandler(this.gastos_CheckedChanged);
            // 
            // ventas
            // 
            this.ventas.AutoSize = true;
            this.ventas.Checked = true;
            this.ventas.Location = new System.Drawing.Point(10, 22);
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(91, 24);
            this.ventas.TabIndex = 0;
            this.ventas.TabStop = true;
            this.ventas.Text = "VENTAS";
            this.ventas.UseVisualStyleBackColor = true;
            this.ventas.CheckedChanged += new System.EventHandler(this.ventas_CheckedChanged);
            // 
            // Ventana_grafica_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grafica);
            this.Name = "Ventana_grafica_ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficas";
            this.Load += new System.EventHandler(this.Ventana_grafica_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Grafica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton julio;
        private System.Windows.Forms.RadioButton junio;
        private System.Windows.Forms.RadioButton mayo;
        private System.Windows.Forms.RadioButton abril;
        private System.Windows.Forms.RadioButton marzo;
        private System.Windows.Forms.RadioButton febrero;
        private System.Windows.Forms.RadioButton enero;
        private System.Windows.Forms.RadioButton diciembre;
        private System.Windows.Forms.RadioButton noviembre;
        private System.Windows.Forms.RadioButton octubre;
        private System.Windows.Forms.RadioButton septiembre;
        private System.Windows.Forms.RadioButton agosto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton clientes;
        private System.Windows.Forms.RadioButton vendedores;
        private System.Windows.Forms.RadioButton gastos;
        private System.Windows.Forms.RadioButton ventas;
    }
}
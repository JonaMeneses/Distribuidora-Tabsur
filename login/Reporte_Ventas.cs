using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class Reporte_Ventas : Form
    {
        public Reporte_Ventas()
        {
            InitializeComponent();
        }

        private void Reporte_Ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSVentas.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DSVentas.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using System.Collections;

namespace login
{
    public partial class Ventana_grafica_ventas : Form
    {
        public Ventana_grafica_ventas()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
       private  ArrayList series =new ArrayList ();
       private ArrayList puntos = new ArrayList();
        public void Seleccionar_mes() {

            Form1.L.db.Conectar();

            int mes = 0;

            if(enero.Checked)
                mes=01; 
            if(febrero.Checked)
                mes=02;
            if (marzo.Checked)
                mes =03;
            if (abril.Checked)
                mes = 04;
            if (mayo.Checked)
                mes = 05;
            if (junio.Checked)
                mes = 06;
            if (julio.Checked)
                mes =07;
            if (agosto.Checked)
                mes = 08;
            if (septiembre.Checked)
                mes = 09;
            if (octubre.Checked)
                mes = 10;
            if (noviembre.Checked)
                mes = 11;
            if (diciembre.Checked)
                mes = 12;
           

            try
            {
                // cambiar el color
                Grafica.Palette = ChartColorPalette.BrightPastel;
                puntos.Clear();
                series.Clear();
                Grafica.Series.Clear();

                int x = 0;
                int x1 = 0;

                if (mes >= 7)
                    x1 = 1;
                if (mes % 2 == x1)
                {
                    if (mes == 02)
                    {
                        if (ventas.Checked)
                        {
                            String query = "select fecha,sum(total_venta) as 'suma' From ventas where fecha between '01/" + mes + "/16' and '28/" + mes + "/16' group by fecha";
                            Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                        }
                        if (gastos.Checked)
                        {
                            String query = "select fecha,sum(cantidad_salida) as 'suma' From pago_salida where fecha between '01/" + mes + "/16' and '28/" + mes + "/16' group by fecha";
                            Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                        }
                        if (vendedores.Checked)
                        {

                            String query = "select  (nombre+' '+paterno) as 'nombre', sum(total_venta) as 'suma' From ventas inner join vendedor on ventas.id_vendedor=vendedor.id_vendedor  where fecha between '01/" + mes + "/16' and '28/" + mes + "/16' group by nombre,paterno";
                            Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);

                        }
                        if (clientes.Checked)
                        {
                            String query = "select  (nombre+' '+paterno) as 'nombre', sum(total_venta) as 'suma' From ventas inner join cliente on ventas.id_cliente=cliente.id_cliente  where fecha between  '01/" + mes + "/16' and '28/" + mes + "/16' group by nombre,paterno";
                            Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                        }


                    }
                    else
                    {
                        if (ventas.Checked)
                        {
                            String query = "select fecha,sum(total_venta) as 'suma' From ventas where fecha between '01/" + mes + "/16' and '30/" + mes + "/16' group by fecha";
                            Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                        }
                        if (gastos.Checked)
                        {
                            String query = "select fecha,sum(cantidad_salida) as 'suma' From pago_salida where fecha between '01/" + mes + "/16' and '30/" + mes + "/16' group by fecha";
                            Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                        }
                        if (vendedores.Checked)
                        {

                            String query = "select  (nombre+' '+paterno) as 'nombre',sum(total_venta) as 'suma' From ventas inner join vendedor on ventas.id_vendedor=vendedor.id_vendedor  where fecha between '01/" + mes + "/16' and '30/" + mes + "/16' group by nombre,paterno";
                            Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);

                        }
                        if (clientes.Checked)
                        {
                            String query = "select (nombre+' '+paterno) as 'nombre',sum(total_venta) as 'suma' From ventas inner join cliente on ventas.id_cliente=cliente.id_cliente  where fecha between  '01/" + mes + "/16' and '30/" + mes + "/16' group by nombre,paterno";
                            Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                        }

                    }

                }
                else
                {

                    if (ventas.Checked)
                    {
                        String query = "select fecha,sum(total_venta) as 'suma' From ventas where fecha between '01/" + mes + "/16' and '31/" + mes + "/16' group by fecha";
                        Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                    }
                    if (gastos.Checked)
                    {
                        String query = "select fecha,sum(cantidad_salida) as 'suma' From pago_salida where fecha between '01/" + mes + "/16' and '31/" + mes + "/16' group by fecha";
                        Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                    }
                    if (vendedores.Checked)
                    {

                        String query = "select  (nombre+' '+paterno) as 'nombre',sum(total_venta) as 'suma' From ventas inner join vendedor on ventas.id_vendedor=vendedor.id_vendedor  where fecha between '01/" + mes + "/16' and '31/" + mes + "/16' group by nombre,paterno";
                        Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);

                    }
                    if (clientes.Checked)
                    {
                        String query = "select  (nombre+' '+paterno) as 'nombre',sum(total_venta) as 'suma' From ventas inner join cliente on ventas.id_cliente=cliente.id_cliente  where fecha between  '01/" + mes + "/16' and '31/" + mes + "/16' group by nombre,paterno";
                        Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                    }

                }

                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {


                    puntos.Add(double.Parse(dr[1].ToString()));
                    series.Add(dr[0].ToString());

                    Series serie = Grafica.Series.Add(series[x].ToString());

                    serie.Label = puntos[x].ToString();

                    serie.Points.Add(int.Parse(puntos[x].ToString()));


                    x++;
                }



                // cambiar el color
                Grafica.Palette = ChartColorPalette.BrightPastel;








            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally {
                
            }

        }

        private void Cargar_grafica() { 
        
        
        
        }

        private void Ventana_grafica_ventas_Load(object sender, EventArgs e)
        {
            Seleccionar_mes();
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Seleccionar_mes();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            
        }

        private void enero_CheckedChanged(object sender, EventArgs e)
        {
            Seleccionar_mes();
        }

        private void febrero_CheckedChanged(object sender, EventArgs e)
        {
            Seleccionar_mes();
        }

        private void marzo_CheckedChanged(object sender, EventArgs e)
        {
            Seleccionar_mes();
        }

        private void abril_CheckedChanged(object sender, EventArgs e)
        {
            Seleccionar_mes();
        }

        private void junio_CheckedChanged(object sender, EventArgs e)
        {
            Seleccionar_mes();
        }

        private void julio_CheckedChanged(object sender, EventArgs e)
        {
            Seleccionar_mes();
        }

        private void agosto_CheckedChanged(object sender, EventArgs e)
        {
            Seleccionar_mes();
        }

        private void septiembre_CheckedChanged(object sender, EventArgs e)
        {
            Seleccionar_mes();
        }

        private void octubre_CheckedChanged(object sender, EventArgs e)
        {
            Seleccionar_mes();
        }

        private void noviembre_CheckedChanged(object sender, EventArgs e)
        {
            Seleccionar_mes();
        }

        private void diciembre_CheckedChanged(object sender, EventArgs e)
        {
            Seleccionar_mes();
        }

        private void ventas_CheckedChanged(object sender, EventArgs e)
        {
            Seleccionar_mes();
        }

        private void gastos_CheckedChanged(object sender, EventArgs e)
        {
            Seleccionar_mes();
        }

        private void vendedores_CheckedChanged(object sender, EventArgs e)
        {
            Seleccionar_mes();
        }

        private void clientes_CheckedChanged(object sender, EventArgs e)
        {
            Seleccionar_mes();
        }





    }
}

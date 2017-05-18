using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login
{
    public partial class Corte_caja : Form
    {
        public Corte_caja()
        {
            InitializeComponent();
        }

        private void Corte_caja_Load(object sender, EventArgs e)
        {
            llenar_tabla();
            llenar_ventas();
            llenar_gastos();
            llenar_fondo();
           

        }

        private void llenar_ventas(){

            try
            {
                Form1.L.db.Conectar();
                String query = "select sum(total_venta) from ventas where fecha='"+System.DateTime.Today.ToShortDateString()+"'";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    lbventas.Text ="$"+ dr[0].ToString();
                }


            }
            catch { }
        
        }

        private void llenar_gastos()
        {

            try
            {
                Form1.L.db.Conectar();
                String query = "select sum(cantidad_salida) from pago_salida where fecha='" + System.DateTime.Today.ToShortDateString() + "'";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    lbgastos.Text ="$"+ dr[0].ToString();
                }


            }
            catch { }

        }

        private void llenar_fondo()
        {

            try
            {
                Form1.L.db.Conectar();
                String query = "select total_neto from corte_caja where fecha='" + System.DateTime.Today.ToShortDateString() + "'";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    lbfondo.Text = "$"+dr[0].ToString();
                }


            }
            catch { }

        }

        public void llenar_tabla()
        {

            tabla.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "select id_entrada, tipo,cantidad_entrada,fecha from pago_entrada where fecha='" + System.DateTime.Today.ToShortDateString() + "'";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla.Rows.Add(dr[0].ToString(),
                    dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Image.FromFile(Application.StartupPath + "\\entrada.png"), "Detalle");


                }

            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message);
            }
            finally
            {
                Form1.L.db.Desconectar();
            }
            

            try
            {
                Form1.L.db.Conectar();
                String query = "select id_salida, tipo,cantidad_salida,fecha from pago_salida where fecha='" + System.DateTime.Today.ToShortDateString() + "'";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla.Rows.Add(dr[0].ToString(),
                    dr[1].ToString(), dr[2].ToString(),dr[3].ToString(), Image.FromFile(Application.StartupPath + "\\salida.png"), "Detalle");


                }

            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message);
            }
            finally
            {
                Form1.L.db.Desconectar();
            }

            try
            {
                Form1.L.db.Conectar();
                String query = "select id_venta,total_venta,fecha from ventas where fecha='" + System.DateTime.Today.ToShortDateString() + "'";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla.Rows.Add( dr[0].ToString(),"Venta",
                    dr[1].ToString(), dr[2].ToString(), Image.FromFile(Application.StartupPath + "\\entrada.png"), "Detalle");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message);
            }
            finally
            {
                Form1.L.db.Desconectar();
            }
        }

        private void tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (tabla.CurrentCell.ColumnIndex == 5)
                {
                    if (tabla.CurrentRow.Cells[1].Value.ToString() == "Venta")
                    {
                        Agregar_Venta av = new Agregar_Venta();
                        av.Show();
                        av.llenar_tabla(tabla.CurrentRow.Cells[0].Value.ToString());
                    }
                    else
                    {

                        Pagos p = new Pagos();
                        p.Show();
                    }
                }
            
           
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte_Ventas rv = new Reporte_Ventas();
            rv.Show();
        }

        private void btnpagos_Click(object sender, EventArgs e)
        {
            Reporte_Ventas rv = new Reporte_Ventas();
            rv.Show();
        }
        
        

    }
}

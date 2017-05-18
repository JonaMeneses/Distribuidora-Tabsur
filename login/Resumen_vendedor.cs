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
    public partial class Resumen_vendedor : Form
    {
        public Resumen_vendedor()
        {
            InitializeComponent();
        }

        private void Resumen_vendedor_Load(object sender, EventArgs e)
        {

        }
            
       
        public void llenar_tabla(int id,string fecha)
        {

            tabla.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "select ventas.id_venta,total_venta,tipo,cliente.id_cliente,cliente.nombre,vendedor.id_vendedor,vendedor.nombre,fecha from ventas inner join cliente on cliente.id_cliente=ventas.id_cliente inner join vendedor on vendedor.id_vendedor=ventas.id_vendedor where ventas.id_vendedor="+id+" and fecha='"+fecha+"'" ;
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla.Rows.Add(dr[0].ToString(),
                    dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(),"Productos");
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
            if(tabla.CurrentCell.ColumnIndex == 8){
                tabla_detalle.Rows.Clear();
            try
            {
                Form1.L.db.Conectar();
                String query = "select producto.id_prod,nombre,precio,iva,cantidad from ventas_producto inner join producto on producto.id_producto=ventas_producto.id_producto inner join ventas on ventas.id_venta=ventas_producto.id_venta where ventas_producto.id_venta=" + tabla.CurrentRow.Cells[0].Value.ToString(); 
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla_detalle.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("" + a.Message);
            }
            finally
            {
                Form1.L.db.Desconectar();
            }

        }
        }
        
        
    }
}

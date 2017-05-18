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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.IsBalloon = true;
            tool.SetToolTip(btnvendedor, "Vendedor");
            tool.SetToolTip(btnclientes, "Clientes");
            tool.SetToolTip(btnpagos, "Gastos");
            tool.SetToolTip(btnVentas, "Ventas");
            tool.SetToolTip(btnalmcen, "Almacen");
            tool.SetToolTip(btnrutas, "Rutas y Mapa");
            tool.SetToolTip(btncaja, "Caja");

            llenar_tabla_ventas();
            llenar_tabla_visitas();
            llenar_tabla_productos();

            if (Form1.L.db.getUsuario()!="administrador"){

                btnalmcen.Enabled = false;
                btnclientes.Enabled = false;
                btnvendedor.Enabled = false;
                btnpagos.Enabled = false;
                btncaja.Enabled = false;

            
            }
          
           
        }

        public void llenar_tabla_ventas() {

            tabla_venta.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "select id_vent,fecha,id_ven,vendedor.nombre,id_cli,cliente.nombre from vendedor inner join ventas on vendedor.id_vendedor=ventas.id_vendedor inner join cliente on cliente.id_cliente=ventas.id_cliente where fecha='"+System.DateTime.Today.ToShortDateString()+"'";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (Form1.L.db.getUsuario() != "administrador")
                    {

                        tabla_venta.Rows.Add(dr[0].ToString(), dr[1].ToString(),
                        dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                    }
                    else {

                        tabla_venta.Rows.Add(dr[0].ToString(), dr[1].ToString(),
                        dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), "Ver");
                    
                    }

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

        public void llenar_tabla_visitas()
        {

            tabla_clientes.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "select id_cli,nombre,paterno,estado from cliente";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (Form1.L.db.getUsuario() != "administrador")
                    {
                        if (dr[3].ToString() == "Visitado")
                            tabla_clientes.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Image.FromFile(Application.StartupPath + "\\si.png"));
                        else
                            tabla_clientes.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Image.FromFile(Application.StartupPath + "\\no.png"));
                    }
                    else {

                        if (dr[3].ToString() == "Visitado")
                            tabla_clientes.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Image.FromFile(Application.StartupPath + "\\si.png"), "Ver");
                        else
                            tabla_clientes.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Image.FromFile(Application.StartupPath + "\\no.png"), "Ver");
                    }
                   
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

        public void llenar_tabla_productos()
        {

            tabla_productos.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "select producto.id_producto,nombre,existencia from producto_almacen inner join producto on producto_almacen.id_producto=producto.id_producto";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (Form1.L.db.getUsuario() != "administrador")
                    {
                        if (int.Parse(dr[2].ToString()) <=10)
                            tabla_productos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Image.FromFile(Application.StartupPath + "\\no.png"));
                        else
                            tabla_productos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Image.FromFile(Application.StartupPath + "\\si.png"));
                    }
                    else {
                        if (int.Parse(dr[2].ToString()) <= 10)
                            tabla_productos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Image.FromFile(Application.StartupPath + "\\no.png"), "Ver");
                        else
                            tabla_productos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Image.FromFile(Application.StartupPath + "\\si.png"), "Ver");
                    
                    }

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
        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.L.Visible = true;
            Form1.L.limpiar();
        }

        private void btnvendedor_Click(object sender, EventArgs e)
        {
           
            Ventana_vendedor VV = new Ventana_vendedor();
            VV.Visible = true;
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            Ventana_cliente VC = new Ventana_cliente();
            VC.Visible = true;
            
        }

        private void btnalmcen_Click(object sender, EventArgs e)
        {
            Ventana_Almacen va = new Ventana_Almacen();
            va.Show();
            
          
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventana_Ventas vv = new Ventana_Ventas();
            vv.Show();
        }

        

        private void btnvendedor_MouseEnter(object sender, EventArgs e)
        {
            
          
            btnvendedor.Image = Image.FromFile(Application.StartupPath+"\\vendedores_brillo.png");
            
          
        }

        private void btnvendedor_MouseLeave(object sender, EventArgs e)
        {
            btnvendedor.Image = Image.FromFile(Application.StartupPath+"\\vendedores.png");
          
            
        }

        private void btnclientes_MouseEnter(object sender, EventArgs e)
        {

            btnclientes.Image = Image.FromFile(Application.StartupPath+"\\clientes_brillo.png");
        }

        private void btnclientes_DragLeave(object sender, EventArgs e)
        {

           
        }

        private void btnclientes_MouseLeave(object sender, EventArgs e)
        {
            
            btnclientes.Image = Image.FromFile(Application.StartupPath+"\\clientes.png");
           
        }

        private void btnCredito_MouseEnter(object sender, EventArgs e)
        {
            btnpagos.Image = Image.FromFile(Application.StartupPath+"\\pagos_brillo.png");
        }

        private void btnCredito_MouseLeave(object sender, EventArgs e)
        {
            btnpagos.Image = Image.FromFile(Application.StartupPath+"\\pagos.png");
        }

        private void btnVentas_MouseEnter(object sender, EventArgs e)
        {
            btnVentas.Image = Image.FromFile(Application.StartupPath+"\\ventas_brillo.png");
        }

        private void btnVentas_MouseLeave(object sender, EventArgs e)
        {
            btnVentas.Image = Image.FromFile(Application.StartupPath+"\\ventas.png");
        }

        private void btnalmcen_MouseEnter(object sender, EventArgs e)
        {
            btnalmcen.Image = Image.FromFile(Application.StartupPath+"\\almacen_brillo.png");
        }

        private void btnalmcen_MouseLeave(object sender, EventArgs e)
        {
            btnalmcen.Image = Image.FromFile(Application.StartupPath+"\\almacen.png");
        }

        private void btnpagos_Click(object sender, EventArgs e)
        {
            Agregar_Pagos P = new Agregar_Pagos();
            P.Show();
            
        }

        private void btnsucursal_MouseEnter(object sender, EventArgs e)
        {
            btnrutas.Image = Image.FromFile(Application.StartupPath + "\\sucursal_brillo.png");
        }

        private void btnsucursal_MouseLeave(object sender, EventArgs e)
        {
            btnrutas.Image = Image.FromFile(Application.StartupPath + "\\sucursal.png");
        }

        private void btnsucursal_Click(object sender, EventArgs e)
        {
            rutas r = new rutas();
            r.Show();
        }

        private void btncaja_Click(object sender, EventArgs e)
        {
            Corte_caja cc = new Corte_caja();
            cc.Show();
           
        }

        private void btnpedidos_Click(object sender, EventArgs e)
        {
            ventana_pedidos vp = new ventana_pedidos();
            vp.Show();
        }

    }
}

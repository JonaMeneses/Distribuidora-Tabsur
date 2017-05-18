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
    public partial class Agregar_Venta : Form
    {
        public Agregar_Venta()
        {
            InitializeComponent();
        }
        

        private void Agregar_Venta_Load(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.IsBalloon = true;
            tool.SetToolTip(btnsalir, "salir");
            tool.SetToolTip(btnagregar, "Agregar");
            tool.SetToolTip(btneliminar, "Eliminar");
            tool.SetToolTip(btngrafica, "Grafica de Ventas");
            tool.SetToolTip(btnLimpiar, "Vaciar cajas de texto");

            

            Form1.L.db.lista = new List<Producto>();
            llenarComboVend();
            llenarComboCliente();
            llenar_tabla();
            llenar_tabla_productos();
            txtfecha.Text = System.DateTime.Now.ToString();

            btnagregar.Enabled = false;
            btneliminar.Enabled = false;


            if (Form1.L.db.getUsuario() != "administrador")
            {

                btneliminar.Enabled = false;
                


            }

            
        }

        public void llenar_tabla_productos() {
            tabla_productos.Rows.Clear();
            try
            {
                Form1.L.db.Conectar();
                String query = "select producto.id_producto,producto.id_prod,nombre,precio,iva,existencia from producto_almacen inner join producto on producto.id_producto=producto_almacen.id_producto ";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {

                    tabla_productos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), "+",0);


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

        public void llenar_tabla_detalle()
        {
            
            try
            {
                Form1.L.db.Conectar();
                String query = "select producto.id_prod,nombre,precio,iva,cantidad from ventas_producto inner join producto on producto.id_producto=ventas_producto.id_producto inner join ventas on ventas.id_venta=ventas_producto.id_venta where ventas_producto.id_venta=" + txtid.Text;
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    Producto p = new Producto(dr[0].ToString(), dr[1].ToString(), double.Parse(dr[2].ToString()), double.Parse(dr[3].ToString()), double.Parse(dr[4].ToString()));
                    Form1.L.db.lista.Add(p);
                    tabla_detalle.Rows.Add(dr[0].ToString(),dr[1].ToString(),dr[2].ToString(),dr[3].ToString(),dr[4].ToString(),"-");
                   

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
        public void llenar_tabla()
        {

            tabla.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "select ventas.id_venta,total_venta,tipo,cliente.id_cliente,cliente.nombre,vendedor.id_vendedor,vendedor.nombre,fecha from ventas inner join cliente on cliente.id_cliente=ventas.id_cliente inner join vendedor on vendedor.id_vendedor=ventas.id_vendedor where fecha='"+ System.DateTime.Today.ToShortDateString()+"'";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla.Rows.Add(dr[0].ToString(),
                    dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());

                   
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
        public void llenar_tabla(string id)
        {

            tabla.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "select ventas.id_venta,total_venta,tipo,cliente.id_cliente,cliente.nombre,vendedor.id_vendedor,vendedor.nombre,fecha from ventas inner join cliente on cliente.id_cliente=ventas.id_cliente inner join vendedor on vendedor.id_vendedor=ventas.id_vendedor where ventas.id_venta="+id;
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla.Rows.Add(dr[0].ToString(),
                    dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());

                }

                Form1.L.db.lista.Clear();

                tabla_detalle.Rows.Clear();

                txtid.Text = tabla.CurrentRow.Cells[0].Value.ToString();
                txttotal.Text = tabla.CurrentRow.Cells[1].Value.ToString();
                txttipo.Text = tabla.CurrentRow.Cells[2].Value.ToString();
                txtcliente.Text = tabla.CurrentRow.Cells[3].Value.ToString();
                txtvendedor.Text = tabla.CurrentRow.Cells[5].Value.ToString();
                txtfecha.Text = tabla.CurrentRow.Cells[7].Value.ToString();


                llenar_tabla_detalle();


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

        public void llenarComboCliente()
        {
            try
            {
                Form1.L.db.Conectar();
                String query = "select * from cliente";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                Form1.L.db.dr = Form1.L.db.cmd.ExecuteReader();
                while (Form1.L.db.dr.Read())
                {

                    txtcliente.Items.Add(Form1.L.db.dr[0].ToString() + "  -  " + Form1.L.db.dr[2].ToString() + " " + Form1.L.db.dr[3].ToString());

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                Form1.L.db.Desconectar();
            }
        }
        public void llenarComboVend()
        {
            try
            {
                Form1.L.db.Conectar();
                String query = "select * from vendedor";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                Form1.L.db.dr = Form1.L.db.cmd.ExecuteReader();
                while (Form1.L.db.dr.Read())
                {

                    txtvendedor.Items.Add(Form1.L.db.dr[0].ToString() + "  -  " + Form1.L.db.dr[2].ToString() + " " + Form1.L.db.dr[3].ToString());

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                Form1.L.db.Desconectar();

            }
        }

        public void validar_botones() {
            if (validar_cajas() == 2)
            {
                if (Form1.L.db.getUsuario() == "administrador")
                {
                    btnagregar.Enabled = false;
                    btneliminar.Enabled = true;
                }
                else {
                    btneliminar.Enabled = false;
                }
            }
            else if (validar_cajas() == 1)
            {
                btneliminar.Enabled = false;
                btnagregar.Enabled = true;
            }
            else {
                btneliminar.Enabled = false;
                btnagregar.Enabled = false;
            }
        
        }
        public int validar_cajas()
        {
            if (txtid.Text != "")
            {
                return 2;
               
            }
            if (txttipo.Text != "" && txtfecha.Text != "" && txtcliente.Text != "" && txtvendedor.Text != "" && tabla_detalle.RowCount != 0)
            {
                return 1;
              
            }
            return 0;
        }
        private double total_venta;
        public void total()
        {
            total_venta = 0;
            if (txttipo.Text == "Contado")
            {
                foreach (Producto p in Form1.L.db.lista)
                {

                    total_venta += p.getprecio() * p.getcantidad();
                }

                txttotal.Text = total_venta.ToString();


            }
            else
            {
                foreach (Producto p in Form1.L.db.lista)
                {

                    total_venta += (p.getprecio()+(p.getprecio()*.01))* p.getcantidad();
                }
                
                txttotal.Text = total_venta.ToString();
        }
    
    
    }
        //animacion de los botones

        private void btnagregar_MouseEnter(object sender, EventArgs e)
        {
            btnagregar.Image = Image.FromFile(Application.StartupPath + "\\agregar_brillo.png");
            
        }

        private void btnagregar_MouseLeave(object sender, EventArgs e)
        {
            btnagregar.Image = Image.FromFile(Application.StartupPath + "\\agregar.png");
        }

        private void btnsalir_MouseEnter(object sender, EventArgs e)
        {
            btnsalir.Image = Image.FromFile(Application.StartupPath + "\\salir_brillo.png");
        }
        private void btnsalir_MouseLeave(object sender, EventArgs e)
        {
            btnsalir.Image = Image.FromFile(Application.StartupPath + "\\salirflat.png");
        }

        private void btnmodificar_MouseEnter(object sender, EventArgs e)
        {
           // btnmodificar.Image = Image.FromFile(Application.StartupPath + "\\modificar_brillo.png");
        }

        private void btnmodificar_MouseLeave(object sender, EventArgs e)
        {
            //btnmodificar.Image = Image.FromFile(Application.StartupPath + "\\modificar.png");
        }

        private void btneliminar_MouseEnter(object sender, EventArgs e)
        {
            btneliminar.Image = Image.FromFile(Application.StartupPath + "\\eliminar_brillo.png");
        }

        private void btneliminar_MouseLeave(object sender, EventArgs e)
        {
            btneliminar.Image = Image.FromFile(Application.StartupPath + "\\eliminar.png");
        }
        //evento clic de los botones

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (validar_cajas() == 1)
            {
                try
                {
                    string result = Form1.L.db.agregar_venta(txttipo.Text, txtfecha.Text,
                    double.Parse(txttotal.Text),double.Parse(txtabono.Text),double.Parse(txtinteres.Text),
                    int.Parse(txtcliente.Text.Remove(1)), int.Parse(txtvendedor.Text.Remove(1)));

                    if (result != null)
                    {
                        MessageBox.Show(result);

                    }


                    //llenar_tabla();
                }
                catch (Exception a)
                {
                    MessageBox.Show("ERROR " + a.Message);
                }
                finally {
                    llenar_tabla();

                    llenar_tabla_productos();
                    actualizar_detalle();
                
                }
            }
            else
            {
                MessageBox.Show("Faltan Datos");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
             if (validar_cajas() == 2)
            {
                try
                {
                    string result = Form1.L.db.eliminar_venta(txtid.Text);
                    if (result != null)
                    {
                     
                        MessageBox.Show(result);
                    }


                    //llenar_tabla();
                }
                catch (Exception a)
                {
                    MessageBox.Show("ERROR " + a.Message);
                }
                finally {
                   
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("Faltan ID");
            }
        }
        

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventana_Ventas vv = new Ventana_Ventas();
            vv.Show();
        }
        public void actualizar_detalle() {

            tabla_detalle.Rows.Clear();
       foreach (Producto p in Form1.L.db.lista) {
                    
                    tabla_detalle.Rows.Add(p.getid(), p.getnombre(), p.getprecio(), p.getiva(), p.getcantidad());
                
                }
       total();
        
        }
       
       
      
       

      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form1.L.db.lista.Clear();

            tabla_detalle.Rows.Clear();
            txtid.Text = tabla.CurrentRow.Cells[0].Value.ToString();
            txttotal.Text = tabla.CurrentRow.Cells[1].Value.ToString();
            txttipo.Text = tabla.CurrentRow.Cells[2].Value.ToString();
            txtcliente.Text = tabla.CurrentRow.Cells[3].Value.ToString();
            txtvendedor.Text = tabla.CurrentRow.Cells[5].Value.ToString();
            txtfecha.Text = tabla.CurrentRow.Cells[7].Value.ToString();


            llenar_tabla_detalle();
          

        }

        public void limpiar() {
            Form1.L.db.lista.Clear();
            tabla_detalle.Rows.Clear();
            txtid.Text = "";
            txttotal.Text = "";
            txttipo.Text = "";
            txtcliente.Text = "";
            txtvendedor.Text = "";
            txtfecha.Text = System.DateTime.Now.ToString();
            llenar_tabla();
            total_venta = 0;


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Quitar_producto_Click(object sender, EventArgs e)
        {
            if (Form1.L.db.lista.Count!=0) {

                Form1.L.db.lista.Reverse();
                Form1.L.db.lista.RemoveAt(0);
                Form1.L.db.lista.Reverse();
                tabla_detalle.Rows.Clear();
                foreach (Producto p in Form1.L.db.lista) {
                    
                    tabla_detalle.Rows.Add(p.getid(), p.getnombre(), p.getprecio(), p.getiva(), p.getcantidad());
                
                }
                total();
            }
        }

        private void Agregar_producto(int tipo,int dev)
        {

           try
            {
                Form1.L.db.Conectar();
                String query = "select id_prod,nombre,precio,iva from producto where id_producto=" + tabla_productos.CurrentRow.Cells[0].Value.ToString();
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    Producto p = new Producto(dr[0].ToString(), dr[1].ToString(), double.Parse(dr[2].ToString()), double.Parse(dr[3].ToString()), double.Parse(tabla_productos.CurrentRow.Cells[7].Value.ToString()),tipo,dev);
                    Form1.L.db.lista.Add(p);
                    string r = "";
                    if (tipo == 0)
                    {
                        if (dev == 1)
                            r = "\\devolucion.png";
                        else
                        r = "\\nuevo.png";
                    }
                    else
                    {
                        if (dev == 1)
                            r = "\\devolucion.png";
                        else
                            r = "\\cambio.png";
                    }

                    tabla_detalle.Rows.Add(p.getid(), p.getnombre(), p.getprecio(), p.getiva(), p.getcantidad(), "-", Image.FromFile(Application.StartupPath + r));

                }

                total();



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
        private void tabla_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           

                //**************************************************************************************                        
                if (tabla_productos.CurrentCell.ColumnIndex == 6)
                {

                    if (tabla_productos.CurrentRow.Cells[7].Value.ToString() != "" || tabla_productos.CurrentRow.Cells[7].Value.ToString() != "0")
                    {

                        if (tabla_productos.CurrentRow.Cells[8].Value == null)
                        {
                            if (tabla_productos.CurrentRow.Cells[9].Value == null)
                            {
                                Agregar_producto(0, 0);
                            }
                            else {
                                Agregar_producto(0, 1);
                            
                            }
                            

                        }
                        else
                        {
                            

                            if (tabla_productos.CurrentRow.Cells[8].Value.ToString() == "True")
                            {
                                if (tabla_productos.CurrentRow.Cells[9].Value == null)
                                {
                                    Agregar_producto(1, 0);
                                }
                                else
                                {
                                    if (tabla_productos.CurrentRow.Cells[9].Value.ToString() == "True")
                                    {
                                        MessageBox.Show("No se puede cambiar y devolver al mismo tiempo");
                                    }
                                    else
                                    {
                                        Agregar_producto(1, 0);

                                    }
                                }
                            }
                            else
                            {
                                if (tabla_productos.CurrentRow.Cells[9].Value.ToString() == "True")
                                {
                                    if (tabla_productos.CurrentRow.Cells[8].Value == null)
                                    {
                                        Agregar_producto(0, 1);
                                    }
                                    else {
                                       
                                            Agregar_producto(0, 1);
                                        
                                    }
                                }
                                else
                                {
                                    Agregar_producto(0, 0);

                                }
                            }

                          }

                    }
                    else
                    {
                        MessageBox.Show("Inserte una cantidad");
                    }
                }
                
            
           
        }

        //en este codigo se bloquean los combo box para que no reciba la entrada del teclado
        private void txttipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            validar_botones();
        }


        private string busqueda = "";
        private void tabla_productos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tabla_productos.IsCurrentCellInEditMode)
            {

            }
            else
            {
                if (e.KeyChar == Convert.ToChar(Keys.Back))
                {
                    llenar_tabla_productos();
                    busqueda = "";
                }
                else
                {
                    tabla_productos.Rows.Clear();
                    busqueda += e.KeyChar.ToString();


                    try
                    {
                        Form1.L.db.Conectar();
                        String query = "Select * From producto where nombre like '%" + busqueda + "%' or id_producto like '%" + busqueda + "'";
                        Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                        Form1.L.db.cmd.CommandType = CommandType.Text;
                        SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            tabla_productos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), "+");
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

        private void tabla_detalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tabla_detalle.CurrentCell.ColumnIndex == 5)
                {
                    Form1.L.db.lista.RemoveAt(tabla_detalle.CurrentRow.Index);
                    tabla_detalle.Rows.RemoveAt(tabla_detalle.CurrentRow.Index);
                }
            }
            catch { }
        }

        private void txttipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void btngrafica_Click(object sender, EventArgs e)
        {
            Ventana_grafica_ventas vgv = new Ventana_grafica_ventas();
            vgv.Show();
        }

        private void txttipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txttipo.Text == "Credito")
            {
                txtinteres.Enabled = true;
                txtabono.Enabled = true;
            }
            else
            {
                txtinteres.Enabled = false;
                txtabono.Enabled = false;
            }
        }

    }
}

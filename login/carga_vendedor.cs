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
    public partial class carga_vendedor : Form
    {
        public carga_vendedor()
        {
            InitializeComponent();
        }

        private void carga_vendedor_Load(object sender, EventArgs e)
        {
            llenar_tabla();
            llenar_tabla_productos();
            Form1.L.db.lista = new List<Producto>();
        }
        public void llenar_tabla()
        {

            tabla.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "Select id_vendedor,nombre,paterno,materno,telefono,ruta,id_sucursal,carga from vendedor";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                string x="";
                while (dr.Read())
                {
                   
                    if (dr[7].ToString() == "True")
                        x = "\\si.png";
                    else
                        x = "\\no.png";

                    tabla.Rows.Add(dr[0].ToString(), dr[1].ToString(),
                    dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(),
                    dr[6].ToString(),dr[7].ToString(), "Ver", Image.FromFile(Application.StartupPath + x));
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
                String query = "select producto.id_producto,producto.id_prod,nombre,precio,iva,existencia from producto_almacen inner join producto on producto.id_producto=producto_almacen.id_producto ";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {

                    tabla_productos.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(),0,"+");


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


    private void Agregar_producto(){

                try
                    {
                        Form1.L.db.Conectar();
                        String query = "select id_prod,nombre,precio,iva from producto where id_producto=" + tabla_productos.CurrentRow.Cells[0].Value.ToString();
                        Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                        Form1.L.db.cmd.CommandType = CommandType.Text;
                        SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            Producto p = new Producto(dr[0].ToString(), dr[1].ToString(), double.Parse(dr[2].ToString()), double.Parse(dr[3].ToString()), double.Parse(tabla_productos.CurrentRow.Cells[6].Value.ToString()));
                            Form1.L.db.lista.Add(p);
                            tabla_detalle.Rows.Add(p.getid(), p.getnombre(), p.getprecio(), p.getiva(), p.getcantidad());

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



    private void tabla_productos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        try { 
        
        //**************************************************************************************                        
        if (tabla_productos.CurrentCell.ColumnIndex == 7)
        {

            if (tabla_productos.CurrentRow.Cells[6].Value.ToString() != "" || tabla_productos.CurrentRow.Cells[6].Value.ToString() != "0")
            {
                Agregar_producto();
            }
            else
            {
                MessageBox.Show("Inserte una cantidad");
            }
        }
        }catch{
        MessageBox.Show("Inserte una cantidad");
        
        }
     }
     
    

        private void tabla_detalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla_detalle.CurrentCell.ColumnIndex == 5)
            {
                
                Form1.L.db.lista.RemoveAt(tabla_detalle.CurrentRow.Index);
                tabla_detalle.Rows.RemoveAt(tabla_detalle.CurrentRow.Index);


            }
        }

        public void actualizar_detalle()
        {

            tabla_detalle.Rows.Clear();
            foreach (Producto p in Form1.L.db.lista)
            {

                tabla_detalle.Rows.Add(p.getid(), p.getnombre(), p.getprecio(), p.getiva(), p.getcantidad());

            }
           
        }
       

        private void btncarga_Click(object sender, EventArgs e)
        {

           if(tabla_detalle.RowCount != 0){

            foreach (DataGridViewRow row in tabla.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[10];
              
                string v = row.Cells[0].Value.ToString();
                if (chk.Selected == true)
                {
                    try
                    {
                        
                        Form1.L.db.agregar_carga(v);
                       

                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("ERROR " + a.Message);
                    }
                    finally
                    {
                        llenar_tabla();
                        
                        llenar_tabla_productos();
                        actualizar_detalle();
                      

                    }
                    break;
                }
                else
                {
                    
                    if (tabla.Rows.Count-1 == row.Index) {
                        MessageBox.Show("Debe agregar Vendedor a la carga");
                        break;
                    
                    }
                    //chk.Selected = true;
                }


            }
           }else{MessageBox.Show("Debe agregar Articulos a la carga");}
          
        }

        private void tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla.CurrentCell.ColumnIndex == 10)
            {
                foreach (DataGridViewRow row in tabla.Rows)
                {
                    
                    row.Cells[10].Value = null;


                }
                tabla.CurrentRow.Cells[10].Value = true;
                
                
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngrafica_Click(object sender, EventArgs e)
        {
            
            if (tabla_detalle.RowCount != 0)
            {

                foreach (DataGridViewRow row in tabla.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[10];
                    
                   
                    string v = row.Cells[0].Value.ToString();
                    if (chk.Selected == true)
                    {
                        if (row.Cells[7].Value.ToString() == "True")
                        {

                            try
                            {

                                Form1.L.db.modificar_carga(v);


                            }
                            catch (Exception a)
                            {
                                MessageBox.Show("ERROR " + a.Message);
                            }
                            finally
                            {
                                llenar_tabla();

                                llenar_tabla_productos();
                                actualizar_detalle();


                            }
                            break;
                        }
                        else {

                            MessageBox.Show("Escoja un Vededor con carga");
                        }
                    }
                    else
                    {

                        if (tabla.Rows.Count - 1 == row.Index)
                        {
                            MessageBox.Show("Debe seleccionar Vendedor a la descarga");
                            break;
 
                        }
                        //chk.Selected = true;
                    }


                }
            }
            else { MessageBox.Show("Debe agregar Articulos a la descarga"); }
          
        }

        private void tabla_productos_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (tabla_productos.CurrentCell.ColumnIndex==6)
            {
                
               
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                    return;
                }

                bool IsDec = false;
                int nroDec = 0;

                for (int i = 0; i < tabla_productos.CurrentCell.Value.ToString().Length; i++)
                {
                    if (tabla_productos.CurrentCell.Value.ToString().IndexOf('.') == i)
                        IsDec = true;

                    if (IsDec && nroDec++ >= 1)
                    {
                        e.Handled = true;
                        return;
                    }


                }

                if (e.KeyChar >= 48 && e.KeyChar <= 57)
                    e.Handled = false;
                else if (e.KeyChar == 46)
                    e.Handled = (IsDec) ? true : false;
                else
                    e.Handled = true;

                //tabla_productos.CurrentCell.Value += e.KeyChar.ToString(); 

                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    Agregar_producto();
                }
            }
            else {

                MessageBox.Show("no lo hizo");
            }

        }

        private void tabla_productos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void tabla_productos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            

        }

        private void tabla_productos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(tabla_productos_KeyPress);
        }






    }
}

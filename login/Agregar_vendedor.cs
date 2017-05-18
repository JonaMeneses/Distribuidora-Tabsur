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
    public partial class Agregar_vendedor : Form
    {
        
        public Agregar_vendedor()
        {

            InitializeComponent();
        }


        //recibe el id del formulario anterior
        public void recibir(int id)
        {

            llenar_tabla(id);

        }

        //metodo para validar las cajas de texto
        public int validar_cajas()
        {
            if (txtid.Text != "")
            {
                return 2;

            }
            if (txtnombre.Text != "" && txtpaterno.Text != "" && txtmaterno.Text != "" && txtlocalidad.Text != ""
                 && txtdireccion.Text != "" && txttelefono.Text != "" && txtruta.Text != "" && txtsueldo.Text != ""
                 && txtsucursal.Text != "")
            {
                return 1;

            }
            return 0;

        }   
        public void llenarCombo()
        {
            try
            {
                Form1.L.db.Conectar();
                String query = "select * from sucursal";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                Form1.L.db.dr = Form1.L.db.cmd.ExecuteReader();
                while (Form1.L.db.dr.Read())
                {

                    txtsucursal.Items.Add(Form1.L.db.dr[0].ToString() + "  -  " + Form1.L.db.dr[2].ToString());

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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        

        //llenado de tablas 
        public void llenar_tabla(int id)
        {

            tabla.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "Select * From vendedor where id_vendedor="+id+"";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla.Rows.Add(dr[0].ToString(),
                    dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(),
                    dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(),
                    dr[10].ToString());
                }

                txtid.Text = tabla.CurrentRow.Cells[0].Value.ToString();
                txtnombre.Text = tabla.CurrentRow.Cells[1].Value.ToString();
                txtpaterno.Text = tabla.CurrentRow.Cells[2].Value.ToString();
                txtmaterno.Text = tabla.CurrentRow.Cells[3].Value.ToString();
                txtdireccion.Text = tabla.CurrentRow.Cells[4].Value.ToString();
                txtlocalidad.Text = tabla.CurrentRow.Cells[5].Value.ToString();
                txttelefono.Text = tabla.CurrentRow.Cells[6].Value.ToString();
                txtsueldo.Text = tabla.CurrentRow.Cells[7].Value.ToString();
                txtruta.Text = tabla.CurrentRow.Cells[8].Value.ToString();
                txtsucursal.Text = tabla.CurrentRow.Cells[9].Value.ToString();
                                
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
               String query = "Select * From vendedor";
               Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
               Form1.L.db.cmd.CommandType = CommandType.Text;
               SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
            while (dr.Read())
            {
                tabla.Rows.Add(dr[0].ToString(), 
                dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(),
                dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(),
                dr[10].ToString());
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


       
        private void Agregar_vendedor_Load(object sender, EventArgs e)
        {
           

            ToolTip tool = new ToolTip();
            tool.IsBalloon = true;
            tool.SetToolTip(btnsalir, "salir");
            tool.SetToolTip(btnagregar, "Agregar");
            tool.SetToolTip(btneliminar, "Eliminar");
            tool.SetToolTip(btnmodificar, "Modificar");
            tool.SetToolTip(btngrafica, "Grafica de Vendedores");

            llenarCombo();  

            llenar_tabla();
            btnagregar.Enabled = false;
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

            

        // Animacion de los botones

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
            btnmodificar.Image = Image.FromFile(Application.StartupPath + "\\modificar_brillo.png");
        }

        private void btnmodificar_MouseLeave(object sender, EventArgs e)
        {
            btnmodificar.Image = Image.FromFile(Application.StartupPath + "\\modificar.png");
        }

        private void btneliminar_MouseEnter(object sender, EventArgs e)
        {
            btneliminar.Image = Image.FromFile(Application.StartupPath + "\\eliminar_brillo.png");
        }

        private void btneliminar_MouseLeave(object sender, EventArgs e)
        {
            btneliminar.Image = Image.FromFile(Application.StartupPath + "\\eliminar.png");
        }

       

        //Evento click de los botones

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            if (validar_cajas() == 1)
            {
                try
                {
                    string result = Form1.L.db.agregar_vendedor(txtnombre.Text, txtpaterno.Text, txtmaterno.Text, txtdireccion.Text, 
                        txtlocalidad.Text,txttelefono.Text, int.Parse(txtsueldo.Text), txtruta.Text, txtsucursal.Text);
                   
                    if (result != null)
                    {
                        MessageBox.Show(result);

                    }
                    llenar_tabla();
                }
                catch (Exception a)
                {
                    MessageBox.Show("ERROR " + a.Message);
                }
            }
            else
            {
                MessageBox.Show("Faltan Datos");
            }
        }

        private void btnmodificar_Click_1(object sender, EventArgs e)
        {
            if (validar_cajas() == 2)
            {
                try
                {
                    string result = Form1.L.db.Modificar_vendedor(int.Parse(txtid.Text), txtnombre.Text, txtpaterno.Text, txtmaterno.Text, txtdireccion.Text,
                        txtlocalidad.Text, txttelefono.Text, int.Parse(txtsueldo.Text), txtruta.Text, txtsucursal.Text);
                    if (result != null)
                    {
                        MessageBox.Show(result);

                    }
                    llenar_tabla();
                }
                catch (Exception a)
                {
                    MessageBox.Show("ERROR " + a.Message);
                }
            }
            else
            {
                MessageBox.Show("Faltan ID");
            }
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            if (validar_cajas() == 2)
            {
                try
                {
                    string result = Form1.L.db.Eliminar_vendedor(int.Parse(txtid.Text));
                    if (result != null)
                    {
                        MessageBox.Show(result);

                    }
                    llenar_tabla();
                }
                catch (Exception a)
                {
                    MessageBox.Show("ERROR " + a.Message);
                }
            }
            else
            {
                MessageBox.Show("Falta ID");
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Ventana_vendedor vv = new Ventana_vendedor();
            vv.Show();
            this.Close();
        }


        //funcion que limpia las cajas de texto para un nuevo registro
        private void limpiar() {
            txtid.Text = "";
            txtnombre.Text = "";
            txtpaterno.Text = "";
            txtmaterno.Text = "";
            txtdireccion.Text = "";
            txtlocalidad.Text = "";
            txttelefono.Text = "";
            txtsueldo.Text = "";
            txtruta.Text = "";
            txtsucursal.Text = "";
            this.txtnombre.Select();
        
        
        }

        //evento que llena las cajas de texto con el registro seleccionado en la tabla
        private void tabla_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtid.Text = tabla.CurrentRow.Cells[0].Value.ToString();
                txtnombre.Text = tabla.CurrentRow.Cells[1].Value.ToString();
                txtpaterno.Text = tabla.CurrentRow.Cells[2].Value.ToString();
                txtmaterno.Text = tabla.CurrentRow.Cells[3].Value.ToString();
                txtdireccion.Text = tabla.CurrentRow.Cells[4].Value.ToString();
                txtlocalidad.Text = tabla.CurrentRow.Cells[5].Value.ToString();
                txttelefono.Text = tabla.CurrentRow.Cells[6].Value.ToString();
                txtsueldo.Text = tabla.CurrentRow.Cells[7].Value.ToString();
                txtruta.Text = tabla.CurrentRow.Cells[8].Value.ToString();
                txtsucursal.Text = tabla.CurrentRow.Cells[9].Value.ToString();
            }
            catch { }

          
        }

        //busqueda predictiva
        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
          /*  tabla.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "Select * From vendedor where nombre like '%"+txtnombre.Text+"%'";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla.Rows.Add(dr[0].ToString(),
                    dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(),
                    dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(),
                    dr[10].ToString());
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
            */
        }

        private void txtpaterno_TextChanged(object sender, EventArgs e)
        {
          /*  tabla.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "Select * From vendedor where paterno like '%" + txtpaterno.Text+"%'";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla.Rows.Add(dr[0].ToString(),
                    dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(),
                    dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(),
                    dr[10].ToString());
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
           * */
        }

        private void txtruta_TextChanged(object sender, EventArgs e)
        {
            /*tabla.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "Select * From vendedor where ruta like '%" + txtpaterno.Text + "%'";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla.Rows.Add(dr[0].ToString(),
                    dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(),
                    dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(),
                    dr[10].ToString());
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
             */
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtpaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtmaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtsucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btngrafica_Click(object sender, EventArgs e)
        {
            Ventana_grafica_ventas gv = new Ventana_grafica_ventas();
            gv.Show();
        }

        public void validar_botones()
        {
            if (validar_cajas() == 2)
            {
                btnagregar.Enabled = false;
                btneliminar.Enabled = true;
                btnmodificar.Enabled = true;
            }
            else if (validar_cajas() == 1)
            {
                btneliminar.Enabled = false;
                btnagregar.Enabled = true;
                btnmodificar.Enabled = false;
            }
            else
            {
                btneliminar.Enabled = false;
                btnagregar.Enabled = false;
                btnmodificar.Enabled = false;

            }

        }
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            validar_botones();
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {

                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtsueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {

                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }




       
    }
}

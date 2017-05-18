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
    public partial class Agregar_Pagos : Form
    {
        public Agregar_Pagos()
        {
            InitializeComponent();
        }

        private void Agregar_Pagos_Load(object sender, EventArgs e)
        {

            ToolTip tool = new ToolTip();
            tool.IsBalloon = true;
            tool.SetToolTip(btnsalir, "salir");
            tool.SetToolTip(btnagregar, "Agregar");
            tool.SetToolTip(btneliminar, "Eliminar");
            tool.SetToolTip(btngrafica, "Grafica de gastos");
          
            llenar_tabla_salida();
            txtfecha.Text = System.DateTime.Now.ToString();

            
            btnagregar.Enabled = false;
            
            btneliminar.Enabled = false;
            
        }

        public void validar_botones()
        {
            if (validar_cajas() == 2)
            {
                btnagregar.Enabled = false;
                btneliminar.Enabled = true;
                
            }
            else if (validar_cajas() == 1)
            {
                btneliminar.Enabled = false;
                btnagregar.Enabled = true;
        

            }
            else
            {
                btneliminar.Enabled = false;
                btnagregar.Enabled = false;
            }

        }

        public void llenar_tabla_salida()
        {

            tabla_salida.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "Select * From pago_salida";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla_salida.Rows.Add(dr[1].ToString(),
                    dr[2].ToString(), dr[3].ToString(), dr[4].ToString(),dr[5].ToString(),"Ver");

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


        public int validar_cajas()
        {
            if (txtid.Text != "")
            {
                return 2;

            }
            if (txttipo.Text != "" && txtfecha.Text != "" && txtcantidad.Text != "")
            {
                return 1;

            }
            return 0;

        }   

        //animacion del boton
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

     /*   private void btnmodificar_MouseEnter(object sender, EventArgs e)
        {
            btnmodificar.Image = Image.FromFile(Application.StartupPath + "\\modificar_brillo.png");
        }

        private void btnmodificar_MouseLeave(object sender, EventArgs e)
        {
            btnmodificar.Image = Image.FromFile(Application.StartupPath + "\\modificar.png");
        }*/

        private void btneliminar_MouseEnter(object sender, EventArgs e)
        {
            btneliminar.Image = Image.FromFile(Application.StartupPath + "\\eliminar_brillo.png");
        }

        private void btneliminar_MouseLeave(object sender, EventArgs e)
        {
            btneliminar.Image = Image.FromFile(Application.StartupPath + "\\eliminar.png");
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
           
            if (validar_cajas() == 1)
            {
                try
                {
                    string result = Form1.L.db.agregar_pago(txttipo.Text, txtfecha.Text, int.Parse(txtcantidad.Text), txtdescripcion.Text);

                    if (result != null)
                    {
                        MessageBox.Show(result);
                    }

                }
                catch (Exception a)
                {
                    MessageBox.Show("ERROR " + a.Message);
                }
                finally {
                    llenar_tabla_salida();
                }
            }
            else
            {
                MessageBox.Show("Faltan Datos");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

            if (validar_cajas() == 2)
            {
                try
                {
                    string result = Form1.L.db.modificar_pago(int.Parse(txtid.Text),txttipo.Text, txtfecha.Text, int.Parse(txtcantidad.Text),txtdescripcion.Text);

                    if (result != null)
                    {
                        MessageBox.Show(result);

                    }

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

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabla_salida_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla_salida.CurrentCell.ColumnIndex == 5)
            {

                try
                {
                    txtid.Text = tabla_salida.CurrentRow.Cells[0].Value.ToString().Remove(0, 8);
                    txtfecha.Text = tabla_salida.CurrentRow.Cells[1].Value.ToString();
                    txttipo.Text = tabla_salida.CurrentRow.Cells[2].Value.ToString();
                    txtcantidad.Text = tabla_salida.CurrentRow.Cells[3].Value.ToString();
                    txtdescripcion.Text = tabla_salida.CurrentRow.Cells[4].Value.ToString();
                }
                catch { }
            }
        }

        private void txttipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtcantidad.Text.Length; i++)
            {
                if (txtcantidad.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
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

        }

        private void btngrafica_Click(object sender, EventArgs e)
        {
            Ventana_grafica_ventas gv = new Ventana_grafica_ventas();
            gv.Show();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            validar_botones();
        }

        private void limpiar() {
            txtid.Text = "";
            txtfecha.Text = "";
            txttipo.Text = "";
            txtcantidad.Text = "";
            txtdescripcion.Text = "";
        
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }



    }
}

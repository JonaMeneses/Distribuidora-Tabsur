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
    public partial class Agregar_clientes : Form
    {
        public Agregar_clientes()
        {
            InitializeComponent();
        }

        public void recibir(int id)
        {

            llenar_tabla(id);

        }


        public void llenar_tabla(int id)
        {

            tabla.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "Select * From cliente where id_cliente="+id;
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla.Rows.Add(dr[0].ToString(),
                    dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(),
                    dr[6].ToString(), dr[7].ToString(), dr[16].ToString(), dr[8].ToString(), dr[9].ToString(),
                    dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString(),
                     dr[14].ToString(), dr[15].ToString(), dr[16].ToString());
                }

                txtid.Text = tabla.CurrentRow.Cells[0].Value.ToString();
                txtnombre.Text = tabla.CurrentRow.Cells[1].Value.ToString();
                txtpaterno.Text = tabla.CurrentRow.Cells[2].Value.ToString();
                txtmaterno.Text = tabla.CurrentRow.Cells[3].Value.ToString();
                txtdireccion.Text = tabla.CurrentRow.Cells[4].Value.ToString();
                txtreferencias.Text = tabla.CurrentRow.Cells[5].Value.ToString();
                txtlocalidad.Text = tabla.CurrentRow.Cells[6].Value.ToString();
                txtcolonia.Text = tabla.CurrentRow.Cells[7].Value.ToString();
                txtestado.Text = tabla.CurrentRow.Cells[8].Value.ToString();
                txttelefono.Text = tabla.CurrentRow.Cells[9].Value.ToString();
                txtlimite.Text = tabla.CurrentRow.Cells[10].Value.ToString();
                txtlocal.Text = tabla.CurrentRow.Cells[11].Value.ToString();
                txtfecha.Text = tabla.CurrentRow.Cells[12].Value.ToString();
                txtsecuencia.Text = tabla.CurrentRow.Cells[13].Value.ToString();
                txttipolocal.Text = tabla.CurrentRow.Cells[14].Value.ToString();
                txtvendedor.Text = tabla.CurrentRow.Cells[15].Value.ToString();
                


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
        public void limpiar() {
            txtid.Text = "";
            txtnombre.Text = "";
            txtpaterno.Text = "";
            txtmaterno.Text = "";
            txtdireccion.Text = "";
            txtreferencias.Text = "";
            txtlocalidad.Text = "";
            txtcolonia.Text = "";
            txtestado.Text = "";
            txttelefono.Text = "";
            txtlimite.Text = "";
            txtlocal.Text = "";
            txtfecha.Text = "";
            txtsecuencia.Text = "";
            txttipolocal.Text = "";
            txtvendedor.Text = "";
            llenar_tabla();
                
        }
        public void llenar_tabla()
        {

            tabla.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "Select * From cliente";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla.Rows.Add(dr[0].ToString(),
                    dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(),
                    dr[6].ToString(), dr[7].ToString(), dr[16].ToString(), dr[8].ToString(), dr[9].ToString(),
                    dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString(),
                     dr[14].ToString(), dr[15].ToString(), dr[16].ToString());
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

        public void llenarCombo()
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
        private void Agregar_clientes_Load(object sender, EventArgs e)
        {
            llenarCombo();
            llenar_tabla();
    
            btnagregar.Enabled = false;
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        //metodo para validar las cajas de texto
        public int validar_cajas()
        {
            if (txtid.Text != "")
            {
                return 2;

            }
            if (txtnombre.Text != "" && txtpaterno.Text != "" && txtmaterno.Text != "" && txtlocalidad.Text != ""
                 && txtdireccion.Text != "" && txttelefono.Text != "" && txtcolonia.Text != "" && txtlocal.Text != ""
                 && txtreferencias.Text != "" && txtlimite.Text!="" && txtestado.Text != "" && txttipolocal.Text != "" && txtsecuencia.Text != ""
                && txtfecha.Text != "" && txtvendedor.Text != "")
            {
                return 1;

            }
            return 0;

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

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            btnmodificar.Image = Image.FromFile(Application.StartupPath + "\\modificar_brillo.png");
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
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

        private void btnsalir_MouseEnter(object sender, EventArgs e)
        {
            btnsalir.Image = Image.FromFile(Application.StartupPath + "\\salir_brillo.png");
        }

        private void btnsalir_MouseLeave(object sender, EventArgs e)
        {
            btnsalir.Image = Image.FromFile(Application.StartupPath + "\\salirflat.png");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        //evento click de los botones
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (validar_cajas() == 1)
            {
                try
                {
                    string result = Form1.L.db.agregar_cliente(txtnombre.Text,txtpaterno.Text,txtmaterno.Text,txtlocalidad.Text,
                txtcolonia.Text, txtdireccion.Text, txtlocal.Text, txtlimite.Text, txttelefono.Text, txtreferencias.Text, txtestado.Text, txttipolocal.Text,
                int.Parse(txtsecuencia.Text),txtfecha.Text,txtvendedor.Text);
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
                    string result = Form1.L.db.Modificar_cliente(txtid.Text,txtnombre.Text, txtpaterno.Text, txtmaterno.Text, txtlocalidad.Text,
                txtcolonia.Text, txtdireccion.Text, txtlocal.Text, txtlimite.Text, txttelefono.Text, txtreferencias.Text, txtestado.Text, txttipolocal.Text,
                int.Parse(txtsecuencia.Text), txtfecha.Text, txtvendedor.Text);
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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (validar_cajas() == 2)
            {
                try
                {
                    string result = Form1.L.db.Eliminar_cliente(int.Parse(txtid.Text.Remove(0,5)));
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ventana_grafica_ventas gv = new Ventana_grafica_ventas();
            gv.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventana_cliente vc = new Ventana_cliente();
            vc.Show();
        }

        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtid.Text = tabla.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = tabla.CurrentRow.Cells[1].Value.ToString();
            txtpaterno.Text = tabla.CurrentRow.Cells[2].Value.ToString();
            txtmaterno.Text = tabla.CurrentRow.Cells[3].Value.ToString();
            txtdireccion.Text = tabla.CurrentRow.Cells[4].Value.ToString();
            txtreferencias.Text = tabla.CurrentRow.Cells[5].Value.ToString();
            txtlocalidad.Text = tabla.CurrentRow.Cells[6].Value.ToString();
            txtcolonia.Text = tabla.CurrentRow.Cells[7].Value.ToString();
            txtestado.Text = tabla.CurrentRow.Cells[8].Value.ToString();
            txttelefono.Text = tabla.CurrentRow.Cells[9].Value.ToString();
            txtlimite.Text = tabla.CurrentRow.Cells[10].Value.ToString();
            txtlocal.Text = tabla.CurrentRow.Cells[11].Value.ToString();
            txtfecha.Text = tabla.CurrentRow.Cells[12].Value.ToString();
            txtsecuencia.Text = tabla.CurrentRow.Cells[13].Value.ToString();
            txttipolocal.Text = tabla.CurrentRow.Cells[14].Value.ToString();
            txtvendedor.Text = tabla.CurrentRow.Cells[15].Value.ToString();
            
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
          

            
            
        
           /* tabla.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "Select * From cliente where nombre like '%" + txtnombre.Text + "%'";
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
           /* tabla.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "Select * From cliente where paterno like '%" + txtpaterno.Text + "%'";
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

        //evita que en los combos se les escriba
        private void solo_lectura(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            validar_botones();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtlimite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar)) {

                e.Handled = false;
            
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtsecuencia_KeyPress(object sender, KeyPressEventArgs e)
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

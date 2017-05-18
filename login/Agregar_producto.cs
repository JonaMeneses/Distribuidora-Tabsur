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
    public partial class Agregar_producto : Form
    {
        public Agregar_producto()
        {
            InitializeComponent();
        }

       

        public void llenar_tabla()
        {

            tabla.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "select id_prod,nombre,descripcion,precio,iva,categoria,existencia,id_alm from producto inner join producto_almacen on producto.id_producto=producto_almacen.id_producto inner join almacen on producto_almacen.id_almacen=almacen.id_almacen";
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
        public void llenar_tabla(string nomb)
        {

            tabla.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "select id_prod,nombre,descripcion,precio,iva,categoria,existencia,id_alm from producto inner join producto_almacen on producto.id_producto=producto_almacen.id_producto inner join almacen on producto_almacen.id_almacen=almacen.id_almacen where producto.nombre='"+nomb+"'";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla.Rows.Add(dr[0].ToString(),
                    dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                }

                txtid.Text = tabla.CurrentRow.Cells[0].Value.ToString().Remove(0, 6);
                txtnombre.Text = tabla.CurrentRow.Cells[1].Value.ToString();
                txtdescripcion.Text = tabla.CurrentRow.Cells[2].Value.ToString();
                txtprecio.Text = tabla.CurrentRow.Cells[3].Value.ToString();
                txtiva.Text = tabla.CurrentRow.Cells[4].Value.ToString();
                txtcategoria.Text = tabla.CurrentRow.Cells[5].Value.ToString();
                txtexistencia.Text = tabla.CurrentRow.Cells[6].Value.ToString();
                txtalmacen.Text = tabla.CurrentRow.Cells[7].Value.ToString();
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
        //Recibe el nombre del producto que se selecciona delde la form anterior 
        public void recibir(string nomb) {

            llenar_tabla(nomb);
        
        }

        //Metodo para validar las cajas de texto
        public int validar_cajas() { 
        if(txtid.Text!="" && txtalmacen.Text!=""){
            return 2;
        
        }
        if (txtnombre.Text != "" && txtprecio.Text != "" && txtiva.Text != "" && txtcategoria.Text != "" && txtalmacen.Text != "")
        {
            return 1;

        }
        return 0;
        }
        
       

        private void Agregar_producto_Load(object sender, EventArgs e)
        {
            btnagregar.Enabled = false;
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;

            ToolTip tool = new ToolTip();
            tool.IsBalloon = true;
            tool.SetToolTip(btnsalir, "salir");
            tool.SetToolTip(btnagregar, "Agregar");
            tool.SetToolTip(btneliminar, "Eliminar");
            tool.SetToolTip(btnmodificar, "Modificar");
            tool.SetToolTip(btngrafica, "Grafica de Productos");

            llenar_tabla();
            llenar_almacen();
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

        public void llenar_almacen() {

            Form1.L.db.Conectar();
            String query = "select id_alm from almacen";
            Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
            Form1.L.db.cmd.CommandType = CommandType.Text;
            SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
            while (dr.Read())
            {
                txtalmacen.Items.Add(dr[0].ToString());
            }

        }
        private void limpiar() {
            txtid.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtprecio.Text = "";
            txtiva.Text ="";
            txtcategoria.Text = "";
            txtexistencia.Text = "";
            txtalmacen.Text ="";
            this.txtnombre.Select();
        
        }
        
        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = tabla.CurrentRow.Cells[0].Value.ToString().Remove(0,6);
            txtnombre.Text = tabla.CurrentRow.Cells[1].Value.ToString();
            txtdescripcion.Text = tabla.CurrentRow.Cells[2].Value.ToString();
            txtprecio.Text = tabla.CurrentRow.Cells[3].Value.ToString();
            txtiva.Text = tabla.CurrentRow.Cells[4].Value.ToString();
            txtcategoria.Text = tabla.CurrentRow.Cells[5].Value.ToString();
            txtexistencia.Text = tabla.CurrentRow.Cells[6].Value.ToString();
            txtalmacen.Text = tabla.CurrentRow.Cells[7].Value.ToString();
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

       //animacion de los botones

        private void btnmodificar_MouseEnter_1(object sender, EventArgs e)
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

        //metodos clic de los botnes

        private void btnmodificar_Click_1(object sender, EventArgs e)
        {
            if (validar_cajas() == 2)
            {
                try
                {
                    string result = Form1.L.db.modificar_producto(int.Parse(txtid.Text),txtnombre.Text,txtdescripcion.Text, Double.Parse(txtprecio.Text),
                         Double.Parse(txtiva.Text), txtcategoria.Text, int.Parse(txtexistencia.Text), int.Parse(txtalmacen.Text.Remove(0,5)));
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

        private void btnagregar_Click_1(object sender, EventArgs e)
        {

            if (validar_cajas() == 1)
            {
                try
                {
                    string result = Form1.L.db.agregar_producto(txtnombre.Text,txtdescripcion.Text, Double.Parse(txtprecio.Text),
                         Double.Parse(txtiva.Text), txtcategoria.Text, int.Parse(txtexistencia.Text), int.Parse(txtalmacen.Text.Remove(0,5)));
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

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            if (validar_cajas() == 2)
            {
                try
                {
                    string result = Form1.L.db.eliminar_producto(int.Parse(txtid.Text),int.Parse(txtalmacen.Text.Remove(0,5)));
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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Ventana_Almacen va = new Ventana_Almacen();
            va.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtcategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')

                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtalmacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtexistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtexistencia.Text.Length; i++)
            {
                if (txtexistencia.Text[i] == '.')
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
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtprecio.Text.Length; i++)
            {
                if (txtprecio.Text[i] == '.')
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
}
}


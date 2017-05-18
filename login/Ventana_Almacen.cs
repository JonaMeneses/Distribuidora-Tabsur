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
    public partial class Ventana_Almacen : Form
    {
        public Ventana_Almacen()
        {
            InitializeComponent();
        }

        public void llenar_tabla()
        {

            tabla.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "select id_alm,nombre,precio,iva,categoria,existencia,existencias from producto inner join producto_almacen on producto.id_producto=producto_almacen.id_producto inner join almacen on producto_almacen.id_almacen=almacen.id_almacen";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla.Rows.Add(dr[0].ToString(),
                    dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(),dr[6].ToString(),"Editar");
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar_producto AP = new Agregar_producto();
            AP.Show();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       
        private void Ventana_Almacen_Load(object sender, EventArgs e)
        {
           llenar_tabla();
            ToolTip tool = new ToolTip();
            tool.IsBalloon = true;
            tool.SetToolTip(btnsalir, "Salir");
            tool.SetToolTip(btnagregar, "Nuevo registro");
            tool.SetToolTip(btnmodificar, "Modificar registros");
            tool.SetToolTip(btneliminar, "Eliminar registros");
            tool.SetToolTip(btngrafica, "Grafica de productos");
        }

      
        private void tabla_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Agregar_producto ap = new Agregar_producto();
            ap.Show();
            ap.recibir(tabla.CurrentRow.Cells[1].Value.ToString());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        

        //Animacion de los botones
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


        //metodos click de los botones 

        private void btngrafica_Click(object sender, EventArgs e)
        {
            Ventana_grafica_ventas gv = new Ventana_grafica_ventas();
            gv.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Agregar_producto ap = new Agregar_producto();
            ap.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Agregar_producto ap = new Agregar_producto();
            ap.Show();
        }
     
        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            Agregar_producto ap = new Agregar_producto();
            ap.Show();
            this.Close();
        }

        private void tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tabla.CurrentCell.ColumnIndex == 7)
                {

                    Agregar_producto ap = new Agregar_producto();
                    ap.Show();
                    ap.recibir(tabla.CurrentRow.Cells[1].Value.ToString());
                    this.Close();

                }
               
                
            }
            catch { }
        }


    }
}

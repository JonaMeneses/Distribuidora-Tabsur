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
    public partial class Ventana_cliente : Form
    {
        public Ventana_cliente()
        {
            InitializeComponent();
        }

        private void tabla_generador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ventana_cliente_Load(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.IsBalloon = true;
            tool.SetToolTip(btnsalir, "Salir");
            tool.SetToolTip(btnagregar, "Nuevo registro");
            tool.SetToolTip(btnmodificar, "Modificar registros");
            tool.SetToolTip(btneliminar, "Eliminar registros");
            tool.SetToolTip(btngrafica, "Grafica de Clientes");

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
                    dr[6].ToString(), dr[7].ToString(), dr[16].ToString(), dr[8].ToString(),
                    dr[9].ToString(),dr[10].ToString(),"Modificar");
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

        //evento click de los botones

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Agregar_clientes ac = new Agregar_clientes();
            ac.Show();
            this.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Agregar_clientes ac = new Agregar_clientes();
            ac.Show();
            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Agregar_clientes ac = new Agregar_clientes();
            ac.Show();
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabla_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Agregar_clientes ac = new Agregar_clientes();
            ac.Show();
            ac.llenar_tabla(int.Parse(tabla.CurrentRow.Cells[0].Value.ToString()));
            this.Close();

        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla.CurrentCell.ColumnIndex == 11)
            {

                Agregar_clientes ac = new Agregar_clientes();
                ac.Show();
                ac.llenar_tabla(int.Parse(tabla.CurrentRow.Cells[0].Value.ToString()));
                this.Close();

            }
        }

        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Agregar_clientes ac = new Agregar_clientes();
            ac.Show();
            ac.llenar_tabla(int.Parse(tabla.CurrentRow.Cells[0].Value.ToString()));
            this.Close();
        }

        private string busqueda = "";
        private void tabla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                llenar_tabla();
                busqueda = "";
            }
            else
            {
                tabla.Rows.Clear();
                busqueda += e.KeyChar.ToString();


                try
                {
                    Form1.L.db.Conectar();
                    String query = "Select * From cliente where nombre like '%" + busqueda + "%' or paterno like '%" + busqueda + "'";
                    Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                    Form1.L.db.cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        tabla.Rows.Add(dr[0].ToString(),
                       dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(),
                       dr[6].ToString(), dr[7].ToString(), dr[16].ToString(), dr[8].ToString(),
                       dr[9].ToString(), dr[10].ToString(), "Modificar");
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

        private void btngrafica_Click(object sender, EventArgs e)
        {
            Ventana_grafica_ventas gv = new Ventana_grafica_ventas();
            gv.Show();
        }
       
      

      

       
    }
}

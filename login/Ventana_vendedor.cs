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
    public partial class Ventana_vendedor : Form
    {
        public Ventana_vendedor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar_vendedor AV = new Agregar_vendedor();
            AV.Show();
        }

        private void Ventana_vendedor_Load(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.IsBalloon = true;
            tool.SetToolTip(btnsalir, "Salir");
            tool.SetToolTip(btnagregar, "Nuevo registro");
            tool.SetToolTip(btnmodificar, "Modificar registros");
            tool.SetToolTip(btneliminar, "Eliminar registros");
            tool.SetToolTip(btngrafica, "Grafica de Vendedores");

            llenar_tabla();
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
                    dr[10].ToString(),"Editar","Ventas");
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

        //Animacion de botones

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

        private void btnagregar_MouseEnter_1(object sender, EventArgs e)
        {
            btnagregar.Image = Image.FromFile(Application.StartupPath + "\\agregar_brillo.png");
        }

        private void btnagregar_MouseLeave_1(object sender, EventArgs e)
        {
            btnagregar.Image = Image.FromFile(Application.StartupPath + "\\agregar.png");
        }

        //Metodos clic de los botones

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            Agregar_vendedor av = new Agregar_vendedor();
            av.Show();
            this.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Agregar_vendedor av = new Agregar_vendedor();
            av.Show();
            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Agregar_vendedor av = new Agregar_vendedor();
            av.Show();
            this.Close();
        }

        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Agregar_vendedor av = new Agregar_vendedor();
                av.Show();
                av.llenar_tabla(int.Parse(tabla.CurrentRow.Cells[0].Value.ToString()));
                this.Close();
            }
            catch { }
        }

        private void tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tabla.CurrentCell.ColumnIndex == 10)
                {

                    Agregar_vendedor av = new Agregar_vendedor();
                    av.Show();
                    av.llenar_tabla(int.Parse(tabla.CurrentRow.Cells[0].Value.ToString()));
                    this.Close();

                }
                else
                {
                    if (tabla.CurrentCell.ColumnIndex == 11)
                    {

                        Resumen_vendedor rv = new Resumen_vendedor();

                        rv.llenar_tabla(int.Parse(tabla.CurrentRow.Cells[0].Value.ToString()),System.DateTime.Now.ToString());
                        rv.Show();


                    }
                }
            }
            catch { }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Ventana_grafica_ventas gv = new Ventana_grafica_ventas();
            gv.Show();
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
                    String query = "Select * From vendedor where nombre like '%" + busqueda + "%' or paterno like '%" + busqueda + "'";
                    Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                    Form1.L.db.cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        tabla.Rows.Add(dr[0].ToString(),
                    dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(),
                    dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(),
                    dr[10].ToString(), "Editar", "Ventas");
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

        private void btncarga_Click(object sender, EventArgs e)
        {
            carga_vendedor ca = new carga_vendedor();
            ca.Show();
        }

    }
}

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
    public partial class Ventana_Ventas : Form
    {
        public Ventana_Ventas()
        {
            InitializeComponent();
        }

        private void Ventana_Ventas_Load(object sender, EventArgs e)
        {
            txtfecha.Text = System.DateTime.Now.ToString("ddMMyyyy");
            ToolTip tool = new ToolTip();
            tool.IsBalloon = true;
            tool.SetToolTip(btnsalir, "Salir");
            tool.SetToolTip(btnagregar, "Nuevo registro");
            tool.SetToolTip(btnmodificar, "Modificar registros");
            tool.SetToolTip(btneliminar, "Eliminar registros");
            tool.SetToolTip(btngrafica, "Grafica de Ventas");
           // llenar_tabla();
        }

        public void llenar_tabla()
        {

            tabla.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "Select * From ventas";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla.Rows.Add(dr[1].ToString(),
                    dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(),"Ver");
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
        private void btnagregar_MouseEnter_1(object sender, EventArgs e)
        {
            btnagregar.Image = Image.FromFile(Application.StartupPath + "\\agregar_brillo.png");
        }

        private void btnagregar_MouseLeave_1(object sender, EventArgs e)
        {
            btnagregar.Image = Image.FromFile(Application.StartupPath + "\\agregar.png");
        }

        private void btnsalir_MouseEnter_1(object sender, EventArgs e)
        {
            btnsalir.Image = Image.FromFile(Application.StartupPath + "\\salir_brillo.png");
        }
        private void btnsalir_MouseLeave_1(object sender, EventArgs e)
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

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Agregar_Venta av = new Agregar_Venta();
            av.Show();
            this.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Agregar_Venta av = new Agregar_Venta();
            av.Show();
            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Agregar_Venta av = new Agregar_Venta();
            av.Show();
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tabla.CurrentCell.ColumnIndex == 6)
                {

                    Agregar_Venta av = new Agregar_Venta();
                    av.Show();
                
                    av.llenar_tabla(tabla.CurrentRow.Cells[0].Value.ToString().Remove(0,7));
                    this.Close();

                }
                
            }
            catch { }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Ventana_grafica_ventas vgv = new Ventana_grafica_ventas();
            vgv.Show();
        }
        private string query = "select*from ventas";
        private void txtfecha_TextChanged(object sender, EventArgs e)
        {
            tabla.Rows.Clear();
           try
            {
              

                Form1.L.db.Conectar();
                try
                {
                    query = "select*from ventas where fecha like '%" + txtfecha.Text.Remove(2) + "' and fecha like '%" + txtfecha.Text.Remove(0, 3).Remove(2) + "%' and fecha like '" + txtfecha.Text.Remove(0, 6) + "%' ";
                }
                catch { }
              
                
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla.Rows.Add(dr[1].ToString(),
                      dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), "Ver");
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

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                txtfecha.Text = "";
                tabla.Rows.Clear();
                try
                {


                    Form1.L.db.Conectar();

                    query = "select*from ventas where id_venta =" + txtid.Text;



                    Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                    Form1.L.db.cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        tabla.Rows.Add(dr[1].ToString(),
                          dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), "Ver");
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
            else { 
            
            }
        }
    }
}

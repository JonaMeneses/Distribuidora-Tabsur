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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void llenar_tabla_entrada()
        {

            tabla_entrada.Rows.Clear();

            try
            {
                Form1.L.db.Conectar();
                String query = "Select * From pago_entrada";
                Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.Text;
                SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
                while (dr.Read())
                {
                    tabla_entrada.Rows.Add(dr[1].ToString(),
                    dr[2].ToString(), dr[3].ToString(), dr[4].ToString());

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
        public void llenar_tabla_salida()
        {

            tabla_entrada.Rows.Clear();

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
                    dr[2].ToString(), dr[3].ToString(), dr[4].ToString());

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

        private void txtcredito_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtcredito_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Agregar_Pagos AP = new Agregar_Pagos();
            AP.Show();
            this.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Agregar_Pagos AP = new Agregar_Pagos();
            AP.Show();
            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Agregar_Pagos AP = new Agregar_Pagos();
            AP.Show();
            this.Close();
        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            llenar_tabla_entrada(); 
            llenar_tabla_salida();
        }
    }
}

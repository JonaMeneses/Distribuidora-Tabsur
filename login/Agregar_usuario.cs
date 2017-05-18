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
    public partial class Agregar_usuario : Form
    {
        
       
        public Agregar_usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.L.Visible = true;
            this.Close();
        }
        
        private void Agregar_usuario_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Checar_campos();
        }
        public void Checar_campos() {
            if (txtcontra.Text == "" || txtid.Text == "" || txttipo.Text == "")
            {
                MessageBox.Show("Debe llenar Todos los campos");
            }
            else {
                agregar();
            }
        }
        public void agregar() {
            try
            {
                
                Form1.L.db.Conectar();
                Form1.L.db.cmd = new SqlCommand("add_usuarios", Form1.L.db.con);
                Form1.L.db.cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter nombre = new SqlParameter("@nom", SqlDbType.VarChar,50);
                nombre.Value = txtid.Text;
                Form1.L.db.cmd.Parameters.Add(nombre);
                SqlParameter contra = new SqlParameter("@contra", SqlDbType.VarChar,120);
                contra.Value = txtcontra.Text;
                Form1.L.db.cmd.Parameters.Add(contra);
                SqlParameter tipo = new SqlParameter("@tipo", SqlDbType.Int);
                tipo.Value = txttipo.Text.Remove(1);
                Form1.L.db.cmd.Parameters.Add(tipo);

                Form1.L.db.cmd.ExecuteNonQuery();
                MessageBox.Show("se registro con exito");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Form1.L.db.Desconectar();
               // Form1.L.llenarCombo();
            }
        
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1.L.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           Form1.L.Visible = true;
            this.Close();
            
        }
    }
}

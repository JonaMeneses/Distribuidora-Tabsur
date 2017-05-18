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

    public partial class Form1 : Form
    {
        public static Form1 L;
        public ConDB db;


        public string Usuario;
        public string Contraseña;
        public string Servidor;
        public Form1()
        {
            
                Form1.L = this;
            InitializeComponent();

        }
    /*    public void llenarCombo()
        {
            try
            {
                db.Conectar();
                String query = "Select nombre From usuarios";
                db.cmd = new SqlCommand(query, db.con);
                db.cmd.CommandType = CommandType.Text;
                db.dr = db.cmd.ExecuteReader();
                while (db.dr.Read())
                {
                    txtid.Items.Add(db.dr[0].ToString());

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {

            }


        }
        private int autenticar()
        {
            servidor = txt_servidor.Text.Remove(13);
           
            int tipo = 0;
            try
            {
                db.Conectar(Usuario,Contraseña,servidor);
                String query = "Select tipo From usuarios where nombre='" + txtid.Text + "' and contraseña='" + txtcontra.Text + "'";
                db.cmd = new SqlCommand(query, db.con);
                db.cmd.CommandType = CommandType.Text;
                db.dr = db.cmd.ExecuteReader();
                while (db.dr.Read())
                {
                    tipo = int.Parse(db.dr[0].ToString());
                    tipoUsuario = tipo;

                }



            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                db.con.Close();

            
            }
            return tipo;
       * }
            */
        
        public void limpiar() {
            txtcontra.Text = "";
            txtid.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            logear();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // llenarCombo();
            try
            {
                SqlConnection con;
                string CadenaCon = "Data Source=JONAMENESES\\SQLEXPRESS;User ID=administrador;Password=123456;Initial Catalog=Distribuidora";
                con = new SqlConnection(CadenaCon);
                con.Open();
            }
            catch(Exception a) {
                MessageBox.Show("La base de datos no se encuentra o tiene un problema "+a.Message);
                panel_rest.Enabled = true;
                panel_rest.Visible = true;
            
            }
      
        }

        private void logear() {
            Usuario = txtid.Text;
            Contraseña = txtcontra.Text;
            Servidor = txt_servidor.Text;

            db = new ConDB(Usuario, Contraseña, Servidor);
           
            try
            {
                db.Conectar();
                db.abrir_caja();
                menu m = new menu();
                m.Show();
                this.Visible = false;

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message.ToString());
            }
            finally
            {
                db.Desconectar();
            }

            /*
            autenticar();
            if (autenticar() != 0)
            {
                menu m = new menu();
                m.Visible = true;

                this.Visible = false;
            }
            else
                MessageBox.Show("Debe iniciar secion para poder entrar");
            */


        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            Usuario = txtid.Text;
            Contraseña = txtcontra.Text;
            Servidor = txt_servidor.Text;
            db = new ConDB(Usuario, Contraseña, Servidor);


            try
            {
                db.Conectar();
                Agregar_usuario AU = new Agregar_usuario();
                AU.Visible = true;
                this.Visible = false;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString());

            }
            finally
            {
                db.Desconectar();
            }

        
            /*autenticar();
            if (autenticar() == 1)
            {
                Agregar_usuario AU = new Agregar_usuario();
                AU.Visible = true;
                this.Visible = false;

            }
            else {
                MessageBox.Show("No tiene los privilegios suficientes para agregar usuarios");
            }
             * */

        }

        private void txt_servidor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {

                logear();
            

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con;
                string CadenaCon = "Data Source=JONAMENESES\\SQLEXPRESS;User ID=administrador;Password=123456;Initial Catalog=Master";
                con = new SqlConnection(CadenaCon);
                con.Open();

                SqlCommand cmd = new SqlCommand(@"restore database ejerc090314 from disk = 'c:\\respaldo_sql\\dist.bak'", con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("La restauracion fue realizado exitosamente");
                  con.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error de la Base de datos: " + a.Message.ToString());
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //db = new ConDB();
           // db.Respaldar();
        }
    }
}

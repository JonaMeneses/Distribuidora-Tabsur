using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace login
{
    public class ConDB
    {
        public CommandType comand;
       public SqlConnection con;
       public SqlCommand cmd;
       public SqlDataReader dr;
        private string CadenaCon;
        private string Usuario;
        private string Contraseña;
        private int Tipo;
        private string Servidor;


       
        public  ConDB() { }

        public  ConDB(string usuario, string contraseña, string servidor) {
            this.Usuario = usuario;
            this.Contraseña = contraseña;
            this.Servidor = servidor;
            
                }
    
    public string getUsuario(){
    return Usuario;
    }
    public void setUsuario(string usuario) {
        this.Usuario = usuario;
    }
    public string getContraseña()
    {
        return Contraseña;
    }
    public void setContraseña(string contraseña)
    {
        this.Contraseña = contraseña;
    }
    public int getTipo() {
        return Tipo;
    }
    public void setTipo(int tipo) {
        this.Tipo = tipo;
    }

    public void Conectar()
    {

        if (Servidor != null || Servidor != "")
        {
            CadenaCon = "Data Source=" + Servidor + ";User ID=" + Usuario + ";Password=" + Contraseña + ";Initial Catalog=Distribuidora";
        }
        else
        {
            CadenaCon = "Data Source=JONAMENESES\\SQLEXPRESS;User ID=" + Usuario + ";Password=" + Contraseña + ";Initial Catalog=Distribuidora";
        }

        con = new SqlConnection(CadenaCon);
        con.Open();
    }

    public void Conectar(string usuario, string contraseña, string servidor)
    {
        if (servidor != null || servidor != "")
        {
            CadenaCon = "Data Source=" + servidor + ";User ID=" + usuario + ";Password=" + contraseña + ";Initial Catalog=Distribuidora";
        }
        else
        {
            CadenaCon = "Data Source=JONAMENESES\\SQLEXPRESS;User ID=" + usuario + ";Password=" + contraseña + ";Initial Catalog=Distribuidora";
        }
      

        con = new SqlConnection(CadenaCon);
        con.Open();
    }
          
    public void Desconectar() {
        con.Close();
        }

        //Almacenados de la entidad PRODUCTOS

    public string agregar_producto(string nombre,string descripcion,double precio,double iva,string categoria,int existencia,int almacen)
    {

        try
        {
           Conectar();
           cmd = new SqlCommand("add_producto",con);
           cmd.CommandType= CommandType.StoredProcedure;
            SqlParameter nom = new SqlParameter("@nombre", SqlDbType.VarChar, 30);
            nom.Value = nombre;
            cmd.Parameters.Add(nom);
            SqlParameter des = new SqlParameter("@descripcion", SqlDbType.Text);
            des.Value =descripcion;
            cmd.Parameters.Add(des);
            SqlParameter pre = new SqlParameter("@precio", SqlDbType.Decimal);
            pre.Value = precio;
            cmd.Parameters.Add(pre);
            SqlParameter IVA = new SqlParameter("@iva", SqlDbType.Decimal);
            IVA.Value = iva;
            cmd.Parameters.Add(IVA);
            SqlParameter cat = new SqlParameter("@categoria", SqlDbType.VarChar, 50);
            cat.Value = categoria;
            cmd.Parameters.Add(cat);
            SqlParameter ext= new SqlParameter("@exist", SqlDbType.Int);
            ext.Value = existencia;
            cmd.Parameters.Add(ext);
            SqlParameter alma = new SqlParameter("@id_almacen", SqlDbType.Int);
            alma.Value = almacen;
            cmd.Parameters.Add(alma);




            cmd.ExecuteNonQuery();
            return "Se Registro con exito";

        }
        catch (Exception e)
        {
            return "Error de BD " + e.Message.ToString();

        }
        finally
        {
            Desconectar();
        }
        


    }
    public String modificar_producto(int id, string nombre,string descripcion, double precio, double iva, string categoria, int existencia, int almacen)
    {

        try
        {
            Conectar();
            cmd = new SqlCommand("update_producto", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter i = new SqlParameter("@id", SqlDbType.Int);
            i.Value = id;
            cmd.Parameters.Add(i);
            SqlParameter nom = new SqlParameter("@nombre", SqlDbType.VarChar, 30);
            nom.Value = nombre;
            cmd.Parameters.Add(nom);
            SqlParameter des = new SqlParameter("@descripcion", SqlDbType.Text);
            des.Value = descripcion;
            cmd.Parameters.Add(des);
            SqlParameter pre = new SqlParameter("@precio", SqlDbType.Decimal);
            pre.Value = precio;
            cmd.Parameters.Add(pre);
            SqlParameter IVA = new SqlParameter("@iva", SqlDbType.Decimal);
            IVA.Value = iva;
            cmd.Parameters.Add(IVA);
            SqlParameter cat = new SqlParameter("@categoria", SqlDbType.VarChar, 50);
            cat.Value = categoria;
            cmd.Parameters.Add(cat);
            SqlParameter ext = new SqlParameter("@exist", SqlDbType.Int);
            ext.Value = existencia;
            cmd.Parameters.Add(ext);
            SqlParameter alma = new SqlParameter("@id_almacen", SqlDbType.Int);
            alma.Value = almacen;
            cmd.Parameters.Add(alma);

            cmd.ExecuteNonQuery();
            return "se Modifico con exito";

        }
        catch (Exception e)
        {
            return "Error de BD " + e.Message.ToString();

        }
        finally
        {
            Desconectar();
        }
    

    }
    public string eliminar_producto(int id,int id_almacen)
    {

        try
        {
            Conectar();
            cmd = new SqlCommand("delete_producto", Form1.L.db.con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter i = new SqlParameter("@id", SqlDbType.Int);
            i.Value = id;
            cmd.Parameters.Add(i);
            SqlParameter alma = new SqlParameter("@id_almacen", SqlDbType.Int);
            alma.Value = id_almacen;
            cmd.Parameters.Add(alma);

            cmd.ExecuteNonQuery();
           return "se elimino con exito";
            

        }
        catch (Exception e)
        {
            return "Error de BD " + e.Message.ToString();

        }
        finally
        {
            Desconectar();
        }


    }
        

        //Almacenados de la Entidad VENDEDORES


    public string agregar_vendedor(string Nombre,string Paterno,string Materno,
        string Direccion,string Localidad,string Telefono,int Sueldo,string Ruta,string Sucursal)
    {
        try
        {
            Conectar();
            cmd = new SqlCommand("add_vendedor", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter nom = new SqlParameter("@nom", SqlDbType.VarChar, 30);
            nom.Value = Nombre;
            cmd.Parameters.Add(nom);
            SqlParameter pat = new SqlParameter("@pat", SqlDbType.VarChar, 30);
            pat.Value = Paterno;
            cmd.Parameters.Add(pat);
            SqlParameter mat = new SqlParameter("@mat", SqlDbType.VarChar, 30);
            mat.Value = Materno;
            cmd.Parameters.Add(mat);
            SqlParameter dir = new SqlParameter("@dir", SqlDbType.VarChar, 50);
            dir.Value = Direccion;
            cmd.Parameters.Add(dir);
            SqlParameter loc = new SqlParameter("@loc", SqlDbType.VarChar, 50);
            loc.Value = Localidad;
            cmd.Parameters.Add(loc);
            SqlParameter tel = new SqlParameter("@tel", SqlDbType.VarChar, 15);
            tel.Value = Telefono;
            cmd.Parameters.Add(tel);
            SqlParameter sueldo = new SqlParameter("@sueldo", SqlDbType.Int);
            sueldo.Value = Sueldo;
            cmd.Parameters.Add(sueldo);
            SqlParameter ruta = new SqlParameter("@ruta", SqlDbType.VarChar, 50);
            ruta.Value = Ruta;
            cmd.Parameters.Add(ruta);
            SqlParameter suc = new SqlParameter("@suc", SqlDbType.Int);
            if (Sucursal.Length > 1)
                suc.Value = int.Parse(Sucursal.Remove(1));
            else
                suc.Value = int.Parse(Sucursal);
            cmd.Parameters.Add(suc);


            cmd.ExecuteNonQuery();
            return "se registro con exito";
          

        }
        catch (Exception e)
        {
            return "Error de BD " + e.Message.ToString();

        }
        finally
        {
            Desconectar();
        }

    }

    public string Modificar_vendedor(int ID, string Nombre, string Paterno, string Materno,
        string Direccion, string Localidad, string Telefono, int Sueldo, string Ruta, string Sucursal)
    {
        try
        {
            Conectar();
            cmd = new SqlCommand("update_vendedor", con);
            cmd.CommandType = CommandType.StoredProcedure;


            SqlParameter id = new SqlParameter("@id", SqlDbType.Int);
            id.Value = ID;
            cmd.Parameters.Add(id);
            SqlParameter nom = new SqlParameter("@nom", SqlDbType.VarChar, 30);
            nom.Value = Nombre;
            cmd.Parameters.Add(nom);
            SqlParameter pat = new SqlParameter("@pat", SqlDbType.VarChar, 30);
            pat.Value = Paterno;
            cmd.Parameters.Add(pat);
            SqlParameter mat = new SqlParameter("@mat", SqlDbType.VarChar, 30);
            mat.Value = Materno;
            cmd.Parameters.Add(mat);
            SqlParameter dir = new SqlParameter("@dir", SqlDbType.VarChar, 50);
            dir.Value = Direccion;
            cmd.Parameters.Add(dir);
            SqlParameter loc = new SqlParameter("@loc", SqlDbType.VarChar, 50);
            loc.Value = Localidad;
            cmd.Parameters.Add(loc);
            SqlParameter tel = new SqlParameter("@tel", SqlDbType.VarChar, 15);
            tel.Value = Telefono;
            cmd.Parameters.Add(tel);
            SqlParameter sueldo = new SqlParameter("@sueldo", SqlDbType.Int);
            sueldo.Value =Sueldo;
            cmd.Parameters.Add(sueldo);
            SqlParameter ruta = new SqlParameter("@ruta", SqlDbType.VarChar, 50);
            ruta.Value = Ruta;
            cmd.Parameters.Add(ruta);
            SqlParameter suc = new SqlParameter("@suc", SqlDbType.Int);
            if (Sucursal.Length > 1)
                suc.Value = int.Parse(Sucursal.Remove(1));
            else
                suc.Value = int.Parse(Sucursal);
            cmd.Parameters.Add(suc);

            cmd.ExecuteNonQuery();
            return "se ha Modificado con exito";


        }
        catch (Exception e)
        {
            return "Error de BD " + e.Message.ToString();

        }
        finally
        {
            Desconectar();
        }

    }

    public string Eliminar_vendedor(int ID)
    {
        try
        {
            Conectar();
            cmd = new SqlCommand("delete_vendedor", con);
            cmd.CommandType = CommandType.StoredProcedure;


            SqlParameter id = new SqlParameter("@id", SqlDbType.Int);
            id.Value = ID;
            cmd.Parameters.Add(id);
           

            cmd.ExecuteNonQuery();
            return "se ha Eliminado con exito";


        }
        catch (Exception e)
        {
            return "Error de BD " + e.Message.ToString();

        }
        finally
        {
            Desconectar();
        }

    }

        //Almacenados de la entidad CLIENTE

    public string agregar_cliente(string Nombre,string Paterno,string Materno,string Localidad,string Colonia,string Direccion,
        string Nombre_local,string Limite_credito,string Telefono,string Referencias,string Estado,string Tipo_Loca,int Secuencia,string Fecha,string Vendedor)
    {
        try
        {
           Conectar();
           cmd = new SqlCommand("add_cliente", Form1.L.db.con);
           cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter nom = new SqlParameter("@nom", SqlDbType.VarChar, 30);
            nom.Value = Nombre;
            cmd.Parameters.Add(nom);
            SqlParameter pat = new SqlParameter("@pat", SqlDbType.VarChar, 30);
            pat.Value = Paterno;
            cmd.Parameters.Add(pat);
            SqlParameter mat = new SqlParameter("@mat", SqlDbType.VarChar, 30);
            mat.Value = Materno;
            cmd.Parameters.Add(mat);
            SqlParameter loc = new SqlParameter("@localidad", SqlDbType.VarChar, 50);
            loc.Value = Localidad;
            cmd.Parameters.Add(loc);
            SqlParameter col = new SqlParameter("@col", SqlDbType.VarChar, 50);
            col.Value = Colonia;
            cmd.Parameters.Add(col);
            SqlParameter dir = new SqlParameter("@direccion", SqlDbType.VarChar, 50);
            dir.Value = Direccion;
            cmd.Parameters.Add(dir);
            SqlParameter nomloc = new SqlParameter("@nom_local", SqlDbType.VarChar, 50);
            nomloc.Value =Nombre_local;
            cmd.Parameters.Add(nomloc);
            SqlParameter lim = new SqlParameter("@limite_credito", SqlDbType.Int);
            lim.Value = Limite_credito;
            cmd.Parameters.Add(lim);
            SqlParameter tel = new SqlParameter("@telefono", SqlDbType.VarChar, 15);
            tel.Value = Telefono;
            cmd.Parameters.Add(tel);
            SqlParameter refe = new SqlParameter("@referencia", SqlDbType.VarChar, 50);
            refe.Value = Referencias;
            cmd.Parameters.Add(refe);
            SqlParameter estado = new SqlParameter("@estado", SqlDbType.VarChar, 50);
            estado.Value = Estado;
            cmd.Parameters.Add(estado);
            SqlParameter tiploc = new SqlParameter("@tipo_local", SqlDbType.VarChar, 15);
            tiploc.Value = Tipo_Loca;
            cmd.Parameters.Add(tiploc);
            SqlParameter sec = new SqlParameter("@secuencia", SqlDbType.Int);
            sec.Value = Secuencia;
            cmd.Parameters.Add(sec);
            SqlParameter fecha = new SqlParameter("@fecha_visita", SqlDbType.VarChar, 15);
            fecha.Value = Fecha;
            cmd.Parameters.Add(fecha);
            SqlParameter vende = new SqlParameter("@id_vendedor", SqlDbType.Int);
            if (Vendedor.Length > 1)
                vende.Value = int.Parse(Vendedor.Remove(1));
            else
                vende.Value = int.Parse(Vendedor);
            cmd.Parameters.Add(vende);


            cmd.ExecuteNonQuery();
            return "se registro con exito";
         

        }
        catch (Exception e)
        {
            return "Error de BD " + e.Message.ToString();

        }
        finally
        {
           Desconectar();
        }

    }

    public string Modificar_cliente(string ID,string Nombre, string Paterno, string Materno, string Localidad, string Colonia, string Direccion,
  string Nombre_local, string Limite_credito, string Telefono, string Referencias, string Estado, string Tipo_Loca, int Secuencia, string Fecha, string Vendedor)
    {
        try
        {
            Conectar();
            cmd = new SqlCommand("update_cliente", Form1.L.db.con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter id = new SqlParameter("@id", SqlDbType.Int);
            id.Value = int.Parse(ID);
            cmd.Parameters.Add(id);
            SqlParameter nom = new SqlParameter("@nom", SqlDbType.VarChar, 30);
            nom.Value = Nombre;
            cmd.Parameters.Add(nom);
            SqlParameter pat = new SqlParameter("@pat", SqlDbType.VarChar, 30);
            pat.Value = Paterno;
            cmd.Parameters.Add(pat);
            SqlParameter mat = new SqlParameter("@mat", SqlDbType.VarChar, 30);
            mat.Value = Materno;
            cmd.Parameters.Add(mat);
            SqlParameter loc = new SqlParameter("@localidad", SqlDbType.VarChar, 50);
            loc.Value = Localidad;
            cmd.Parameters.Add(loc);
            SqlParameter col = new SqlParameter("@col", SqlDbType.VarChar, 50);
            col.Value = Colonia;
            cmd.Parameters.Add(col);
            SqlParameter dir = new SqlParameter("@direccion", SqlDbType.VarChar, 50);
            dir.Value = Direccion;
            cmd.Parameters.Add(dir);
            SqlParameter nomloc = new SqlParameter("@nom_local", SqlDbType.VarChar, 50);
            nomloc.Value = Nombre_local;
            cmd.Parameters.Add(nomloc);
            SqlParameter lim = new SqlParameter("@limite_credito", SqlDbType.Int);
            lim.Value = Limite_credito;
            cmd.Parameters.Add(lim);
            SqlParameter tel = new SqlParameter("@telefono", SqlDbType.VarChar, 15);
            tel.Value = Telefono;
            cmd.Parameters.Add(tel);
            SqlParameter refe = new SqlParameter("@referencia", SqlDbType.VarChar, 50);
            refe.Value = Referencias;
            cmd.Parameters.Add(refe);
            SqlParameter estado = new SqlParameter("@estado", SqlDbType.VarChar, 50);
            estado.Value = Estado;
            cmd.Parameters.Add(estado);
            SqlParameter tiploc = new SqlParameter("@tipo_local", SqlDbType.VarChar, 50);
            tiploc.Value = Tipo_Loca;
            cmd.Parameters.Add(tiploc);
            SqlParameter sec = new SqlParameter("@secuencia", SqlDbType.Int);
            sec.Value = Secuencia;
            cmd.Parameters.Add(sec);
            SqlParameter fecha = new SqlParameter("@fecha_visita", SqlDbType.VarChar, 15);
            fecha.Value = Fecha;
            cmd.Parameters.Add(fecha);
            SqlParameter vende = new SqlParameter("@id_vendedor", SqlDbType.Int);
            if (Vendedor.Length>1)
            vende.Value = int.Parse(Vendedor.Remove(1));
            else
                vende.Value = int.Parse(Vendedor);
            cmd.Parameters.Add(vende);


            cmd.ExecuteNonQuery();
            return "se modifico con exito";


        }
        catch (Exception e)
        {
            return "Error de BD " + e.Message.ToString();

        }
        finally
        {
            Desconectar();
        }

    }

    public string Eliminar_cliente(int ID)
    {
        try
        {
            Conectar();
            cmd = new SqlCommand("delete_cliente", Form1.L.db.con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter id = new SqlParameter("@id", SqlDbType.Int);
            id.Value = ID;
            cmd.Parameters.Add(id);
            

            cmd.ExecuteNonQuery();
            return "se registro con exito";


        }
        catch (Exception e)
        {
            return "Error de BD " + e.Message.ToString();

        }
        finally
        {
            Desconectar();
        }

    }

    public List<Producto> lista ;
        private string iddev;
    public string agregar_venta(string Tipo, string Fecha, double total_venta,double abono,double interes, int Cliente, int Vendedor)
    {

        string pr = "";
        int x = 0;
        

            

            try
            {
                Conectar();
                cmd = new SqlCommand("add_venta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter total = new SqlParameter("@total", SqlDbType.Decimal);
                total.Value = total_venta;
                cmd.Parameters.Add(total);
                SqlParameter inte = new SqlParameter("@interes", SqlDbType.Decimal);
                inte.Value = interes;
                cmd.Parameters.Add(inte);
                SqlParameter abo = new SqlParameter("@abono", SqlDbType.Decimal);
                abo.Value = abono;
                cmd.Parameters.Add(abo);
                SqlParameter tipo = new SqlParameter("@tipo", SqlDbType.VarChar, 30);
                tipo.Value = Tipo;
                cmd.Parameters.Add(tipo);
                SqlParameter fecha = new SqlParameter("@fecha", SqlDbType.Date);
                fecha.Value = Fecha;
                cmd.Parameters.Add(fecha);
                SqlParameter cliente = new SqlParameter("@cliente", SqlDbType.Int);
                cliente.Value = Cliente;
                cmd.Parameters.Add(cliente);
                SqlParameter vend = new SqlParameter("@vendedor", SqlDbType.Int);
                vend.Value = Vendedor;
                cmd.Parameters.Add(vend);
                SqlParameter id = new SqlParameter("@id_devuelto", SqlDbType.Int);
                id.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(id);

                cmd.ExecuteNonQuery();
                int ID = Int32.Parse(cmd.Parameters["@id_devuelto"].Value.ToString());
                iddev = ID.ToString();
              

               
            }
            catch (Exception e)
            {
                return "Error al realizar la venta " + e.Message;
            }
            finally {
                Desconectar();
            }

            try
                {
                   Conectar();
            foreach (Producto prod in Form1.L.db.lista)
            {
                int b = 0;
                
                 
                    cmd = new SqlCommand("update_producto_almacen", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter id_p = new SqlParameter("@id", SqlDbType.Int);
                    id_p.Value = int.Parse(prod.getid().Remove(0, 6));
                    cmd.Parameters.Add(id_p);

                    SqlParameter cant = new SqlParameter("@exis", SqlDbType.Decimal);
                    cant.Value = prod.getcantidad();
                    cmd.Parameters.Add(cant);

                    SqlParameter sumres = new SqlParameter("@sumres", SqlDbType.Int);
                    sumres.Value = b;
                    cmd.Parameters.Add(sumres);

                    SqlParameter Vacio = new SqlParameter("@x", SqlDbType.Decimal);
                    Vacio.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(Vacio);

                    cmd.ExecuteNonQuery();
               
                
                double vac = double.Parse(cmd.Parameters["@x"].Value.ToString());
               
                if (vac <= 0)
                {

                    MessageBox.Show("No hay suficiente " + prod.getnombre() + " en existencia ");
                    lista.Remove(prod);
                    

                }
                else
                {
                    x++;
                    if (x == 1)
                        pr += "(" + iddev + "," + prod.getid().Remove(0, 6) + "," + prod.getcantidad() + "," + prod.getTipo() + "," + prod.getDev() + ")";
                    else
                        pr += ",(" + iddev + "," + prod.getid().Remove(0, 6) + "," + prod.getcantidad() + "," + prod.getTipo() + "," + prod.getDev() + ")";

                }

            }

            if (pr != "")
            {


                string sql = @"INSERT INTO ventas_producto
                        (id_venta,id_producto,cantidad,tipo) values " + pr;


                cmd.ResetCommandTimeout();
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            else {
                eliminar_venta(iddev);
            }

            return "Se Registro con exito ";

                }
            catch {return "error update"; }
            finally
            {
                Desconectar();
            }

       
      


    }
    public string eliminar_venta(string id_vent)
    {

        try
        {
            Conectar();

            foreach (Producto prod in Form1.L.db.lista)
            {
                int b = 1;
                try
                {
                    cmd = new SqlCommand("update_producto_almacen", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter id_p = new SqlParameter("@id", SqlDbType.Int);
                    id_p.Value = int.Parse(prod.getid().Remove(0, 6));
                    cmd.Parameters.Add(id_p);

                    SqlParameter cant = new SqlParameter("@exis", SqlDbType.Decimal);
                    cant.Value = prod.getcantidad();
                    cmd.Parameters.Add(cant);

                    SqlParameter sumres = new SqlParameter("@sumres", SqlDbType.Int);
                    sumres.Value = b;
                    cmd.Parameters.Add(sumres);

                    SqlParameter Vacio = new SqlParameter("@x", SqlDbType.Decimal);
                    Vacio.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(Vacio);

                    cmd.ExecuteNonQuery();
                }
                catch { MessageBox.Show("error update"); }
            }

            cmd = new SqlCommand("delete_venta", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter i = new SqlParameter("@id", SqlDbType.Int);
            i.Value = int.Parse(id_vent);
            cmd.Parameters.Add(i);



            cmd.ExecuteNonQuery();
            return "Se Elimino con exito ";


        }
        catch (Exception e)
        {
            return "Error de BD eliminar_venta" + e.Message.ToString();

        }
        finally
        {
            Desconectar();
           
        }

    }
    public string agregar_pago_entrada(string fecha, string tipo, double cantidad)
    {

        try
        {
            Conectar();
            cmd = new SqlCommand("add_producto", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter nom = new SqlParameter("@fecha", SqlDbType.Date);
            nom.Value = fecha;
            cmd.Parameters.Add(nom);
            SqlParameter pre = new SqlParameter("@precio", SqlDbType.VarChar,30);
            pre.Value = tipo;
            cmd.Parameters.Add(pre);
            SqlParameter IVA = new SqlParameter("@iva", SqlDbType.Decimal);
            IVA.Value = cantidad;
            cmd.Parameters.Add(IVA);
           




            cmd.ExecuteNonQuery();
            return "Se Registro con exito";

        }
        catch (Exception e)
        {
            return "Error de BD " + e.Message.ToString();

        }
        finally
        {
            Desconectar();
        }



    }

    public string agregar_pago(string tipo, string fecha, double cantidad,string descripcion)
    {

        try
        {
            Conectar();
            cmd = new SqlCommand("add_pagos", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter tip = new SqlParameter("@tipo", SqlDbType.VarChar, 30);
            tip.Value = tipo;
            cmd.Parameters.Add(tip);
            SqlParameter fec = new SqlParameter("@fecha", SqlDbType.Date);
            fec.Value = fecha;
            cmd.Parameters.Add(fec);
            SqlParameter cant = new SqlParameter("@cantidad", SqlDbType.Decimal);
            cant.Value =cantidad;
            cmd.Parameters.Add(cant);
            SqlParameter desc = new SqlParameter("@descripcion", SqlDbType.Text);
            desc.Value = descripcion;
            cmd.Parameters.Add(desc);
            
      




            cmd.ExecuteNonQuery();
            return "Se Registro con exito";

        }
        catch (Exception e)
        {
            return "Error de BD " + e.Message.ToString();

        }
        finally
        {
            Desconectar();
        }



    }
    public string modificar_pago(int id,string tipo, string fecha, double cantidad,string descripcion)
    {

        try
        {
            Conectar();
            cmd = new SqlCommand("update_pagos", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter i = new SqlParameter("@id", SqlDbType.Int);
            i.Value = id;
            cmd.Parameters.Add(i);
            SqlParameter tip = new SqlParameter("@tipo", SqlDbType.VarChar, 30);
            tip.Value = tipo;
            cmd.Parameters.Add(tip);
            SqlParameter fec = new SqlParameter("@fecha", SqlDbType.Date);
            fec.Value = fecha;
            cmd.Parameters.Add(fec);
            SqlParameter cant = new SqlParameter("@cantidad", SqlDbType.Decimal);
            cant.Value = cantidad;
            cmd.Parameters.Add(cant);
            SqlParameter desc = new SqlParameter("@descripcion", SqlDbType.Text);
            desc.Value = descripcion;
            cmd.Parameters.Add(desc);
            




            cmd.ExecuteNonQuery();
            return "Se Registro con exito";

        }
        catch (Exception e)
        {
            return "Error de BD " + e.Message.ToString();

        }
        finally
        {
            Desconectar();
        }
    }

    public string Eliminar_pagos(int ID, int entsal,string fech)
    {
        try
        {
            Conectar();
            cmd = new SqlCommand("delete_pagos", Form1.L.db.con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter id = new SqlParameter("@id", SqlDbType.Int);
            id.Value = ID;
            cmd.Parameters.Add(id);
            SqlParameter ent = new SqlParameter("@entsal", SqlDbType.Int);
            ent.Value = entsal;
            cmd.Parameters.Add(ent);
            SqlParameter fecha = new SqlParameter("@fecha", SqlDbType.Date);
            fecha.Value =fech ;
            cmd.Parameters.Add(fecha);

            
            cmd.ExecuteNonQuery();
            return "se registro con exito";


        }
        catch (Exception e)
        {
            return "Error de BD "+e.Message.ToString();

        }
        finally
        {
            Desconectar();
        }

    }

    public void Respaldar() {
        try
        {

            SqlConnection conx;
            string CadenaCon = "Data Source=JONAMENESES\\SQLEXPRESS;User ID=administrador;Password=123456;Initial Catalog=Distribuidora";
            conx = new SqlConnection(CadenaCon);
            conx.Open();

            SqlCommand cmd = new SqlCommand("backupdb", conx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            MessageBox.Show("El backup fue realizado exitosamente");
            conx.Close();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }
        
    }
    public string Restaurar()
    {
        try
        {
            SqlConnection con;
            string CadenaCon = "Data Source=JONAMENESES\\SQLEXPRESS;User ID=administrador;Password=sa;Initial Catalog=Master";
            con = new SqlConnection(CadenaCon);
            con.Open();

            SqlCommand cmd = new SqlCommand(@"restore database ejerc090314 from disk = 'c:\ respaldo_sql\dist.bak'",con );
        
            cmd.ExecuteNonQuery();
            return "La restauracion fue realizado exitosamente";
        }
        catch (Exception e)
        {
            return "Error de la Base de datos: " + e.Message.ToString();
        }
    }
    public void abrir_caja() {
        string x = "";
        Regex rgex = new Regex("[0-9]"); // exprecion regular para validar la cantidad que entra del dialogo aceptando solo del 0 al 9
        try
        {
            Form1.L.db.Conectar();
            String query = "select fecha from corte_caja where fecha='"+System.DateTime.Today.ToShortDateString()+"'";
            Form1.L.db.cmd = new SqlCommand(query, Form1.L.db.con);
            Form1.L.db.cmd.CommandType = CommandType.Text;
            SqlDataReader dr = Form1.L.db.cmd.ExecuteReader();
            while (dr.Read())
            {
                 x = dr[0].ToString();
            }

            if (x == "") {
               bool a=rgex.IsMatch(x);
                while (a==false)
                { 
                 x = Interaction.InputBox("Se debe abrir una caja con un valor determinado, agregue el fondo fijo con numeros");
                 a=rgex.IsMatch(x);
                 if (rgex.IsMatch(x) == false)
                 {
                     MessageBox.Show("agregue un valor numerico");
                 }


                 if (x == "") {
                     MessageBox.Show("Debera crear una caja con fondo para iniciar el sistema");
                     a = true;
                     Form1.L.Close();
                }
                          
                 }
                agregar_corte_caja(x);
            }

        }
        catch (Exception e)
        {
            MessageBox.Show("" + e.Message);
        }
    
    }

    public void agregar_corte_caja(string total_neto) {

        try
        {
            Conectar();
            cmd = new SqlCommand("add_corte_caja", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter tot = new SqlParameter("@total_corte", SqlDbType.Decimal);
            tot.Value =0;
            cmd.Parameters.Add(tot);
            SqlParameter tot_net = new SqlParameter("@total_neto", SqlDbType.Decimal);
            tot_net.Value = double.Parse(total_neto);
            cmd.Parameters.Add(tot_net);
           

            cmd.ExecuteNonQuery();
            MessageBox.Show("Se creo la caja de manera correcta con un fondo de: $"+total_neto);

        }
        catch (Exception e)
        {
           MessageBox.Show(e.Message.ToString());

        }
        finally
        {
            Desconectar();
        }

    
    }
    public void agregar_carga(string id_ven) {
        try
        {
            Conectar();

            string pr = "";
            int x = 0;

            
                string sql1 = @"update vendedor set carga=1 where id_vendedor=" + id_ven;
                cmd = new SqlCommand(sql1, con);
                cmd.ExecuteNonQuery();
                cmd.ResetCommandTimeout();
            

            foreach (Producto prod in Form1.L.db.lista)
            {
              
                try
                {
                    cmd = new SqlCommand("update_producto_almacen", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter id_p = new SqlParameter("@id", SqlDbType.Int);
                    id_p.Value = int.Parse(prod.getid().Remove(0, 6));
                    cmd.Parameters.Add(id_p);

                    SqlParameter cant = new SqlParameter("@exis", SqlDbType.Decimal);
                    cant.Value = prod.getcantidad();
                    cmd.Parameters.Add(cant);

                    SqlParameter sumres1 = new SqlParameter("@sumres", SqlDbType.Int);
                    sumres1.Value = 1;
                    cmd.Parameters.Add(sumres1);


                    SqlParameter Vacio = new SqlParameter("@x", SqlDbType.Decimal);
                    Vacio.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(Vacio);

                    cmd.ExecuteNonQuery();
                }
                catch(Exception a) { MessageBox.Show("error update"+a.Message); }

                double vac = double.Parse(cmd.Parameters["@x"].Value.ToString());

                if (vac <= 0)
                {

                    MessageBox.Show("No hay suficiente " + prod.getnombre() + " en existencia ");
                    lista.Remove(prod);


                }
                else
                {
                    x++;
                    if (x == 1)
                        pr += "(" + id_ven + "," + (prod.getid().Remove(0, 6) + "," + prod.getcantidad()) + ",'"+DateTime.Today.ToShortDateString()+"')";
                    else
                        pr += ",(" + id_ven + "," + (prod.getid().Remove(0, 6) + "," + prod.getcantidad()) + ",'"+DateTime.Today.ToShortDateString() + "')";

                }

            }

            try
            {


                string sql = @"INSERT INTO vendedor_producto
                        (id_vendedor,id_producto,cantidad,fecha) values " + pr;



                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();


            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
            

            MessageBox.Show("Se Cargo con exito ");


        }
        catch 
        {

            MessageBox.Show("Se elimino producto de la carga");
        }
        finally
        {

            Desconectar();
        }
    
    
    
    }

    public void modificar_carga(string id_ven)
    {
        try
        {
            Conectar();

            

            string sql1 = @"update vendedor set carga=0 where id_vendedor=" + id_ven;
            cmd = new SqlCommand(sql1, con);
            cmd.ExecuteNonQuery();
            cmd.ResetCommandTimeout();


            foreach (Producto prod in Form1.L.db.lista)
            {

                try
                {
                    cmd = new SqlCommand("update_producto_almacen", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter id_p = new SqlParameter("@id", SqlDbType.Int);
                    id_p.Value = int.Parse(prod.getid().Remove(0, 6));
                    cmd.Parameters.Add(id_p);

                    SqlParameter cant = new SqlParameter("@exis", SqlDbType.Decimal);
                    cant.Value = prod.getcantidad();
                    cmd.Parameters.Add(cant);

                    SqlParameter sumres1 = new SqlParameter("@sumres", SqlDbType.Int);
                    sumres1.Value = 0;
                    cmd.Parameters.Add(sumres1);


                    SqlParameter Vacio = new SqlParameter("@x", SqlDbType.Decimal);
                    Vacio.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(Vacio);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception a) { MessageBox.Show("error update" + a.Message); }




                MessageBox.Show("Se Cargo con exito ");

            }
        }
        catch
        {

            MessageBox.Show("Se elimino producto de la descarga");
        }
        finally
        {

            Desconectar();
        }



    }



    }
}

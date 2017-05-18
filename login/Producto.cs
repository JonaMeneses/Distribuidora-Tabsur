using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace login
{
   public class Producto
    {
        private string ID;
        private string Nombre;
        private double Precio;
        private double IVA;
        private double Cantidad;
        private int Tipo;
        private int Dev;
        public Producto() { 
        
        }

        public Producto(string id,string nombre,double precio,double iva,double cantidad)
        {
           
            this.ID = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.IVA = iva;
            this.Cantidad = cantidad;
        }

        public Producto(string id, string nombre, double precio, double iva, double cantidad,int tipo,int dev)
        {

            this.ID = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.IVA = iva;
            this.Cantidad = cantidad;
            this.Tipo = tipo;
            this.Dev = dev;
        }

        public string getid(){
            return this.ID;
    }
        public void setid(string id) {

            this.ID = id;
        }

        public string getnombre()
        {
            return this.Nombre;
        }
        public void setnombre(string nombre)
        {

            this.Nombre = nombre;
        }
        public double getprecio()
        {
            return this.Precio;
        }
        public void setprecio(double precio)
        {

            this.Precio = precio;
        }
        public double getiva()
        {
            return this.IVA;
        }
        public void setiva(double iva)
        {
            this.IVA = iva;
        }
       
        public double getcantidad()
        {
            return this.Cantidad;
        }
        public void setcantidad(double cantidad)
        {

            this.Cantidad = cantidad;
        }

        public double getTipo()
        {
            return this.Tipo;
        }
        public void settipo(int tipo)
        {

            this.Tipo=tipo;
        }
        public double getDev()
        {
            return this.Dev;
        }
        public void setDev(int dev)
        {

            this.Dev = dev;
        }


        public override string ToString()
        {

            return String.Format("{0}{1}{2}{3}{5}", ID,Nombre,Precio,IVA,Cantidad);
        }
    }
}

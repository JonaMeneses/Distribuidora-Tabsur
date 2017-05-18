using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;

namespace login
{
    public partial class rutas : Form
    {
        public rutas()
        {
            InitializeComponent();
        }

        private void rutas_Load(object sender, EventArgs e)
        {
            try
            {
                mapa.DragButton = MouseButtons.Left;
                mapa.CanDragMap = true;
                mapa.MapProvider = GMapProviders.BingMap;
                mapa.Position = new PointLatLng(18.366971, -95.797142);
                mapa.MinZoom = 0;
                mapa.MaxZoom = 24;
                mapa.Zoom = 15;
                mapa.AutoScroll = true;
                
                
            }
            catch (Exception a){
                MessageBox.Show(a.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

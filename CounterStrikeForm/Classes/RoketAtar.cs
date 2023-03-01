using CounterStrikeOdev.Enums;
using CounterStrikeOdev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrikeOdev.Classes
{
    internal class RoketAtar : AtesliSilahlar, IZoom
    {
        public RoketAtar()
        {
            this.MenzilTipi = EMenzilTipi.DahaUzakMesafe; //set kapat
            this.MermiTipi = EMermiTipi.Roket; //set kapat
            this.MermiSayisi = 1;
            this.MermiKapasitesi = 1;
            this.Agirlik = "15";//set kapat
            this.Model = "RoketAtar";
            this.ResimLokasyonu = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Pictures\RoketAtar.jpg");
            this.SarjorSesiLokasyonu = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Sounds\Silah2.wav");
            this.AtesSesiLokasyonu = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Sounds\TopAtis.wav");
            //this.SarjorSesi = "";
            //this.AtesSesi = "";  
        }

        public string zoom { get; set; }

        public bool zoomAcikMi { get; set; } = false;

        public void ZoomChange()
        {
            zoomAcikMi = !zoomAcikMi;

            if (zoomAcikMi)
            {
                MessageBox.Show("Zoom acik");
                zoom = "Açık";
            }
            else if (!zoomAcikMi)
            {
                MessageBox.Show("Zoom kapali");
                zoom = "Kapalı";
            }

        }
    }
}

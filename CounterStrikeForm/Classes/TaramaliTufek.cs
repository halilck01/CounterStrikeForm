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
    internal class TaramaliTufek : Tufek, IZoom
    {
        public TaramaliTufek()
        {
            this.tufekTipi = ETufekTipi.Taramali; //set kapat
            this.MenzilTipi = EMenzilTipi.DahaUzakMesafe; //set kapat
            this.MermiTipi = EMermiTipi.Cekirdekli; //set kapat
            this.MermiSayisi = 50;
            this.MermiKapasitesi = 50;
            this.Agirlik = "9";//set kapat
            this.Model = "Taramalı";
            this.ResimLokasyonu = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Pictures\TaramaliTufek.jpg");
            this.SarjorSesiLokasyonu = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Sounds\Taramali2.wav");
            this.AtesSesiLokasyonu = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Sounds\Taramali.wav");
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

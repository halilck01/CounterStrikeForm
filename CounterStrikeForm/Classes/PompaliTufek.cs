using CounterStrikeOdev.Enums;
using CounterStrikeOdev.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrikeOdev.Classes
{
    internal class PompaliTufek : Tufek
    {

        public PompaliTufek()
        {
            this.tufekTipi = ETufekTipi.Pompali; //set kapat
            this.MenzilTipi = EMenzilTipi.YakinMesafe; //set kapat
            this.MermiTipi = EMermiTipi.Sacma; //set kapat
            this.MermiSayisi = 4;
            this.MermiKapasitesi = 4;
            this.Agirlik = "10";//set kapat
            this.Model = "Pompalı";
            this.ResimLokasyonu = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Pictures\PompaliTufek.jpg");
            this.SarjorSesiLokasyonu = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Sounds\PompaliSarjor.wav");
            this.AtesSesiLokasyonu = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Sounds\Pompali.wav");
            //this.SarjorSesi = "";
            //this.AtesSesi = "";  
        }


        public override void SarjorDoldur()
        {
            SoundPlayer sarjorDoldurmaSesi = new SoundPlayer($@"{this.SarjorSesiLokasyonu}");

            if (MermiSayisi == MermiKapasitesi)
            {
                MessageBox.Show("Pompalı Sarjor doludur!");
            }
            else
            {
                sarjorDoldurmaSesi.Play();
                MermiSayisi++;
            }
        }


    }
}

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
    internal class Tabanca : AtesliSilahlar
    {
        public Tabanca()
        {
            this.MenzilTipi = EMenzilTipi.UzakMesafe; //set kapat
            this.MermiTipi = EMermiTipi.Cekirdekli; //set kapat
            this.MermiSayisi = 15;
            this.MermiKapasitesi = 15;
            this.Agirlik = "3";//set kapat
            this.Model = "Tabanca";
            this.ResimLokasyonu = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Pictures\Tabanca.jpg");
            this.SarjorSesiLokasyonu = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Sounds\silah1.wav");
            this.AtesSesiLokasyonu = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Sounds\Tabanca.wav");
            //this.SarjorSesi = "";
            //this.AtesSesi = "";  
        }

    }
}

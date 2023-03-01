using CounterStrikeForm.Enums;
using CounterStrikeOdev.Enums;
using CounterStrikeOdev.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrikeOdev.Classes
{
    internal class Bicak : Silahlar, IBicaklar
    {
        public Bicak()
        {
            this.MenzilTipi = EMenzilTipi.DahaUzakMesafe; //set kapat
            this.Agirlik = "1";
            this.Model = "Bicak";
            this.ResimLokasyonu = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Pictures\Bicak.jpg");
        }
        public int kesmeSayisi { get; set; }
        public string bileyleSesLokasyonu { get; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Sounds\SharpenKnife.wav");
        public string kesSesLokasyonu { get; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Sounds\StabKnife.wav");
        public EBileyDurumu BileyDurumu { get; set; } = EBileyDurumu.iyi;

        public void Bileyle()
        {
            if (BileyDurumu == EBileyDurumu.orta)
            {
                BileyDurumu = EBileyDurumu.iyi;
            }
            else if (BileyDurumu == EBileyDurumu.kotu)
            {
                BileyDurumu = EBileyDurumu.orta;
            }
            MessageBox.Show($"Bileylendi. Durumu artık {BileyDurumu}");
        }

        public void Kes()
        {
            if (kesmeSayisi < 6)
            {
                kesmeSayisi++;
                if (kesmeSayisi < 6)
                {
                    Console.WriteLine($"Dusman {kesmeSayisi} kez kesildi.");
                    if (kesmeSayisi % 2 == 0)
                    {
                        if (BileyDurumu == EBileyDurumu.orta)
                        {
                            BileyDurumu = EBileyDurumu.kotu;
                        }
                        else if (BileyDurumu == EBileyDurumu.iyi)
                        {
                            BileyDurumu = EBileyDurumu.orta;
                        }
                    }

                }
                if (kesmeSayisi == 6)
                {
                    Console.WriteLine($"Dusman 6 kez kesildi ve oldu.");
                    kesmeSayisi = 0;
                }
            }

        }


    }
}

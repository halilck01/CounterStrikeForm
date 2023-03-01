using CounterStrikeOdev.Enums;
using CounterStrikeOdev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace CounterStrikeOdev.Classes
{
    internal abstract class AtesliSilahlar : Silahlar, IAtesliSilahlar
    {
        public EMermiTipi MermiTipi { get; set; }
        public int MermiKapasitesi { get; set; }
        public string Kalibre { get; set; }
        public int MermiSayisi { get; set; }

        public string AtesSesiLokasyonu { get; set; }
        public string SarjorSesiLokasyonu { get; set; }
        public string SarjorBosSesiLokasyonu { get ; set ; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Sounds\GunEmpty.wav");

        public virtual void AtesEt()
        {
            SoundPlayer atesSesi = new SoundPlayer($@"{this.AtesSesiLokasyonu}");
            SoundPlayer olumSesi = new SoundPlayer($@"{this.OldurmeSesiLokasyonu}");
            SoundPlayer sarjorBosSesi = new SoundPlayer($@"{this.SarjorBosSesiLokasyonu}");
            if (MermiSayisi > 0 )
            {
                Random rnd = new Random();
                int deger = rnd.Next(1, 7);
             
                MermiSayisi--;
                //Ses dosyasi gelecek.

                
                atesSesi.Play();

                if (deger == 1) //turnery-If'e cevir bu kismi
                {
                    MessageBox.Show("Dusman oldu");


                    olumSesi.Play();
                }
                else if (deger != 1)
                {
                    MessageBox.Show("Dusman yasiyor");
                }

            }
            else 
            {
                MessageBox.Show("Mermi yok. Sarjor doldur");

                sarjorBosSesi.Play();
            }
        }

        public virtual void SarjorDoldur()
        {
            SoundPlayer sarjorDoldurmaSesi = new SoundPlayer($@"{this.SarjorSesiLokasyonu}");
            if (MermiSayisi == MermiKapasitesi)
            {
                MessageBox.Show("Sarjor doludur!");
            }
            else
            {
                MermiSayisi = MermiKapasitesi;

                sarjorDoldurmaSesi.Play();
            }
        }
    }
}

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
    public abstract class Silahlar : ISilahlar
    {
        public string Marka { get;  }
        public string Model { get; set; }
        public string Agirlik { get; set; }
        public EMenzilTipi MenzilTipi { get; set; }
        public string ResimLokasyonu { get; set; }

        public string OldurmeSesiLokasyonu { get; set; } =  Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Sounds\death.wav");

    }
}

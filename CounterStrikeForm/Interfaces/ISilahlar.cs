using CounterStrikeOdev.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrikeOdev.Interfaces
{

    internal interface ISilahlar
    {

        string Marka { get;  }
        string Model { get; set; }
        EMenzilTipi MenzilTipi { get; }
        string Agirlik { get;  }
        public string ResimLokasyonu { get; set; }
        string OldurmeSesiLokasyonu { get; set; }

    }
}

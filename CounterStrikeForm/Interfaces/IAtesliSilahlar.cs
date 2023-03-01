using CounterStrikeOdev.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrikeOdev.Interfaces
{
    internal interface IAtesliSilahlar
    {


        EMermiTipi MermiTipi { get;  }

        int MermiKapasitesi { get;  }

        string Kalibre { get;  }

        int MermiSayisi { get;  }

        string AtesSesiLokasyonu { get; set; }

        string SarjorSesiLokasyonu { get; set; }

        string SarjorBosSesiLokasyonu { get; set; }




        void SarjorDoldur();

        void AtesEt();



    }
}

using CounterStrikeOdev.Enums;
using CounterStrikeOdev.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CounterStrikeOdev.Classes
{
    internal abstract class Tufek : AtesliSilahlar, ITufek
    {

        public ETufekTipi tufekTipi { get; set; }
    }
}

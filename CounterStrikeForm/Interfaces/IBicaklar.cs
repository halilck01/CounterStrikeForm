using CounterStrikeForm.Enums;

namespace CounterStrikeOdev.Interfaces
{
    internal interface IBicaklar
    {
        void Bileyle();
        void Kes();

        public string bileyleSesLokasyonu { get;}

        public string kesSesLokasyonu { get; }

        int kesmeSayisi { get; set; }

        public EBileyDurumu BileyDurumu { get; set; }
    }
}
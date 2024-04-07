using _01_OOPCounterStrikeLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOPCounterStrikeLibrary.Concrete
{
    public class Top : AtesliSilah
    {
        string url = @"\..\..\..\..\01-OOPCounterStrikeLibrary\Sesler";
        public Top(string marka, string model, double agirlik) : base(marka, model, agirlik, Menzil.ÇokUzakMenzil, false, 152, false)
        {
            this.AudioPathFire = @$"{url}\Tabanca.wav";
            this.AudioParhReload = @$"{url}\silah1.wav";
            this.MaxMermiSayisi = 1;
        }

        public override string Doldur()
        {
            if (this.MermiAdet < this.MaxMermiSayisi)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = this.AudioParhReload;
                sp.Play();

                this.MermiAdet = this.MaxMermiSayisi;

                return $"Top {this.MaxMermiSayisi} mermilik şarjör takıldı";
            }
            else
            {
                return "Şarjör Dolu";
            }
        }
    }
}

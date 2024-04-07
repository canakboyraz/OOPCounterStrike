using _01_OOPCounterStrikeLibrary.Abstract;
using _01_OOPCounterStrikeLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOPCounterStrikeLibrary.Concrete
{
    public class Tabanca : AtesliSilah
    {
        string url = @"\..\..\..\..\01-OOPCounterStrikeLibrary\Sesler";
        public Tabanca(string marka, string model, double agirlik, bool yivliMi, double kalibre, bool durbunluMu) : base(marka, model, agirlik, Menzil.UzakMenzil, yivliMi, kalibre, durbunluMu)
        {
            this.AudioPathFire = @$"{url}\Tabanca.wav";
            this.AudioParhReload = @$"{url}\silah1.wav";
            this.MaxMermiSayisi = 15;
            this.Mermisi = MermiTipi.Çekirdekli;
        }
     
        public override string Doldur()
        {
            if (this.MermiAdet < this.MaxMermiSayisi)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = this.AudioParhReload;
                sp.Play();

                this.MermiAdet = this.MaxMermiSayisi;

                return $"Tabancaya {this.MaxMermiSayisi} mermilik şarjör takıldı";
            }
            else
            {
                return "Şarjör Dolu";
            }
        }
    }
}

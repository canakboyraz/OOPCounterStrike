using _01_OOPCounterStrikeLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOPCounterStrikeLibrary.Concrete
{
    public class Tufek : AtesliSilah
    {
        string url = @"\..\..\..\..\01-OOPCounterStrikeLibrary\Sesler";
        public TufekTipi Tip { get; set; }
        public Tufek(string marka, string model, double agirlik, bool yivliMi, double kalibre, bool durbunluMu,TufekTipi tip) : base(marka, model, agirlik, Menzil.UzakMenzil, yivliMi, kalibre, durbunluMu)
        {
            this.Tip = tip;

            if (Tip == TufekTipi.PompaliTufek)
            {
                this.Mermisi = MermiTipi.Sacmali;
                this.AudioPathFire = @$"{url}\Pompali.wav";
                this.AudioParhReload = @$"{url}\PompaliSarjor.wav";
                this.MaxMermiSayisi = 8;
            }
            else if (Tip == TufekTipi.TaramaliTufek)
            {
                this.Mermisi = MermiTipi.Çekirdekli;
                this.AudioPathFire = @$"{url}\Taramali.wav";
                this.AudioParhReload = @$"{url}\Taramali1.wav";
                this.MaxMermiSayisi = 30;
            }
        }

        public override string Doldur()
        {
            if (this.Tip == TufekTipi.TaramaliTufek && this.MermiAdet < this.MaxMermiSayisi)     
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = this.AudioParhReload;
                sp.Play();

                this.MermiAdet = this.MaxMermiSayisi;

                return $"Tufek {this.MaxMermiSayisi} mermilik şarjör takıldı";
            }
            else if (this.Tip == TufekTipi.PompaliTufek && this.MermiAdet < this.MaxMermiSayisi)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = this.AudioParhReload;
                sp.Play();

                this.MermiAdet = this.MaxMermiSayisi;

                return $"Tufek {this.MaxMermiSayisi} mermilik şarjör takıldı";
            }
            else
            {
                return "Şarjör Dolu";
            }
        }
    }
}

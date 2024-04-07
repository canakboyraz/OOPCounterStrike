using _01_OOPCounterStrikeLibrary.Abstract;
using _01_OOPCounterStrikeLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOPCounterStrikeLibrary.Concrete
{
    public abstract class AtesliSilah : Silah,IAtes,IYakinlastir
    {
        public AtesliSilah(string marka, string model, double agirlik, Menzil menzil,bool yivliMi, double kalibre, bool durbunluMu) : base(marka, model, agirlik, menzil, true)
        {
            this.Kalibre = kalibre;
            this.YivliMi = yivliMi;
            this.DurbunluMu = durbunluMu; 
        }

        public bool YivliMi { get; set; }
        public double Kalibre { get; set; }
        public bool DurbunluMu { get; set; }
        public MermiTipi Mermisi { get; set; }
        public int MermiAdet { get; set; }
        public int MaxMermiSayisi { get; set; }

        public Random Olasilik = new Random();

        public string AudioPathFire { get; set; }
        public string AudioParhReload { get; set; }

        public string AtesEt()
        {
            int oldurduMu = Olasilik.Next(1,3);
            string url = @"\..\..\..\..\01-OOPCounterStrikeLibrary\Sesler";
            if (MermiAdet > 0)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = this.AudioPathFire;

                sp.PlaySync();
                this.MermiAdet--;

                return "Ateş edildi ve " + ((oldurduMu == 1) ? Yarala() : Oldur());
            }
            else
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = $@"{url}\GunEmpty.wav";
                sp.PlaySync();

                return "Mermimiz Bitti";
            }
        }

        // Ateşli silahını miras alan kendisi Doldur() metodunu doldursun.
        public abstract string Doldur();

        // IYakinlastir interfaceinden implimente edildi.
        public string Yakinlastir()
        {
            return this.DurbunluMu ? "Yakınlaştırıldı " : " Silahınız dürbünsüzdür!";
        }


        public string Uzaklastir()
        {
            return this.DurbunluMu ? "Uzaklaştır " : " Silahınız dürbünsüzdür!";
        }
        
    }
}

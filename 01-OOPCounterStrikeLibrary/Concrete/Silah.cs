using _01_OOPCounterStrikeLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOPCounterStrikeLibrary.Concrete
{
    public class Silah // base class
    {
        public double Agirlik { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public bool AtesliMi { get; set; }
        public Menzil Menzil { get; set; }

        // Bunu yazarak defoult contracktırı çiğnemiş oluyoruz.
        // silahtan miras alan bu parametreleri doldurmak zorunda.
        public Silah(string marka, string model, double agirlik, Menzil menzil, bool atesliMi)
        {
            this.Menzil = menzil;
            this.Agirlik = agirlik;
            this.Marka = marka;
            this.Model = model;
            this.AtesliMi = atesliMi;
        }

        string url = @"\..\..\..\..\01-OOPCounterStrikeLibrary\Sesler";

        internal string Oldur()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = $@"{url}\death.wav";

            sp.Play();
            return "Öldürüldü";
        }

        internal string Yarala()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = $@"{url}\scream.wav";

            sp.Play();
            return "Yaralandı";
        }
    }
}

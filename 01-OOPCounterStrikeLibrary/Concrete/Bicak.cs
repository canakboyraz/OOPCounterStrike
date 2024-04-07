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
    // Bıçak bir silah mıdır ? Tabanca, Top, Tüfek
    // Derived Class
    public class Bicak : Silah, IKesici  // base class
    {

        private int _kesmeSayisi; // field

        public Bicak(string marka, string model, double agirlik) : base(marka, model, agirlik, Menzil.YakinMenzil, false)
        {
            _kesmeSayisi = 5;
        }

        string url = @"..\..\..\..\01-OOPCounterStrikeLibrary\Sesler";
        public string Bileyle()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = $@"{url}\SharpenKnife.wav";

            sp.Play();
            return "Bileylendi";
        }

        public string Kes()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = $@"{url}\StabKnife.wav";

            sp.PlaySync();

            if (_kesmeSayisi > 0)
            {
                _kesmeSayisi--;
                return "Yaralandı";
            }
            else if(_kesmeSayisi == 0)
            {
                _kesmeSayisi = 5;
                return Oldur() + " ve " + Bileyle();
            }

            return "";
        }

        // Bileyleme ve Kesme 
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOPCounterStrikeLibrary.Abstract
{
    internal interface IKesici // IKesici interfaceinden implimente alan sınıflar Kes ve Bileyle metotlarını doldurmak zorundadırlar.
    {
        string Kes();
        string Bileyle();
    }
}

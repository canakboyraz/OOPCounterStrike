using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOPCounterStrikeLibrary.Abstract
{
    internal interface IYakinlastir
    {
        bool DurbunluMu { get; set; }
        string Yakinlastir();
        string Uzaklastir();
    }
}

using Baseline.ImTools;
using LamarCodeGeneration.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soyut
{
    internal class Inheritance
    {
        class Matematik
        {
    
            public int carpma(int x , int y)
            {
                return (x * y);
            }

            public double bolme(int x,int y)
            {
                return (x / y);
            }

            public int toplama(int x, int y)
            {
                return (x + y);
            }
            public int cikarma(int x, int y)
            {
                return (x - y);
            }
        }
        class Dikdortgen : Matematik
        {
            public int alanHesapla(int x, int y)
            {
                return base.carpma(x,y);
            }
        }
        class Ucgen : Dikdortgen
        {
            public double alani(int a, int b)
            {
                return bolme(alanHesapla(a, b), 2);
            }
        } 
    }
}

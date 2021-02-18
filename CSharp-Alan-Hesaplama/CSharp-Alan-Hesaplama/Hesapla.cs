using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Alan_Hesaplama
{
	class Hesapla
	{
        public int UAlani(int UcgenA, int UcgenH)
        {
            return (UcgenA * UcgenH) / 2;
        }
        public int KAlani(int KareA)
        {
            return KareA * KareA;
        }
        public int DikAlani(int DikA, int DikH)
        {
            return DikA * DikH;
        }
        public double DAlani(double r)
        {
            return Math.PI * r * r;
        }
    }
}

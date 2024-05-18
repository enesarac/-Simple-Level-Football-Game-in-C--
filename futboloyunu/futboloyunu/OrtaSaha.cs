using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futboloyunu
{
    internal class OrtaSaha: IFutbolcuYetenekleri1
    {
        public string SutAt()
        {
            return "Orta saha oyuncusu şut çekti!";
        }
       
        public string  GolAt()
        {
            return "Forvet gol için topa vurdu!";
        }
        public string PasVer()
        {
            return "Takım arkadaşına pas verdi!";
        }
    }
}

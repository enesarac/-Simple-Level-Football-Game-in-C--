using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace futboloyunu
{
    internal class oyuncu : IFutbolcuYetenekleri1

    {
        public string SutAt()
        {
            return "SutAt";
        }
        public string PasVer()
        {
            return "Oyuncu ara pas verdi";
        }
        public string GolAt()
        {
            return "Golat";
        }

    }
}

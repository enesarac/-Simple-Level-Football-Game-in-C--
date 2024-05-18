using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futboloyunu
{
    internal class Defans: IFutbolcuYetenekleri1
    {
        public string SutAt()
        {
            return "Futbolcu şut çekti!";
        }
        public string PasVer()
        {
            return "Oyuncuya pas attı!!";
        }
        public string GolAt()
        {
            return "Topu filelere gönderdi!";
        }
    }
}

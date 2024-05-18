using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futboloyunu
{
    internal class Kale2: KaleciYetenekleri
    {
        private Random random = new Random();
        private int puan = 0;
        public string GolDurumu()
        {
            int rastgeleGolDurumu = random.Next(1, 101);

            if (rastgeleGolDurumu <= 30) 
            {
                puan++;
                return "Gol oldu! ŞanlıurfaSpor Takım Skoru:" + puan;
            }
            else
            {
                return "Gol olmadı. ŞanlıurfaSpor Takım Skoru:" + puan;
            }
        }
        public string TopTut()
        {
            return "Kaleci topu tuttu, gol değil!";
        }
        public string TopuFırlat()
        {
            return "Kaleci topu fırlattı!";
        }

    }
}

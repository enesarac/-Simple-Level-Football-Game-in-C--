using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace futboloyunu
{
   public class Kale:KaleciYetenekleri
    {
        private Random random = new Random();
        private int puan = 0;
        public string GolDurumu()
        {
            int rastgeleGolDurumu = random.Next(1, 101); // Rastgele bir değer oluştur

            if (rastgeleGolDurumu <= 60) // Örnek olarak %60 şansla gol
            {
                puan++;
                return "Gol oldu! Galatasaray Takım Skoru:"+puan;
            }
            else
            {
                return "Gol olmadı.Galatasaray Takım Skoru:"+puan;
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

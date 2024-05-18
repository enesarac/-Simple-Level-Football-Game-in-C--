using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futboloyunu
{
    public partial class Form1 : Form
    {
        private Kale kaleci = new Kale();
        private OrtaSaha ortaSaha = new OrtaSaha();
        private Defans defans = new Defans();
        private Kale2 kaleci2= new Kale2();
        private int skorA = 0;
        private int skorB = 0;
        private oyuncu oyuncuu = new oyuncu();


        public Form1()
        {
            InitializeComponent();
            UpdateSkorLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Kaleci1_Click(object sender, EventArgs e)
        {
            string sonuc= kaleci2.GolDurumu();
            if (sonuc.Contains("Gol oldu"))
            {
                skorA++;
               
            }
            UpdateSkorLabel();
            label1.Text = sonuc;
        
        }
        

        private void Kaleci2_Click(object sender, EventArgs e)
        {
            string sonuc = kaleci.GolDurumu();
            if (sonuc.Contains("Gol oldu"))
            {
                skorB++;
                
            }
            UpdateSkorLabel();

            label1.Text = sonuc;
           
           
        }

        private void Orta1_Click(object sender, EventArgs e)
        {
            string sonuc =ortaSaha.PasVer();
            label1.Text = sonuc;
        }

        private void Orta2_Click(object sender, EventArgs e)
        {
            string sonuc=ortaSaha.SutAt();
            label1.Text = sonuc;
        }

        private void Defans2_Click(object sender, EventArgs e)
        {
            string sonuc = defans.PasVer();
            label1.Text = sonuc;
        }

        private void Defans1_Click(object sender, EventArgs e)
        {
            string sonuc = defans.GolAt();
            label1.Text = sonuc;
        }

       
        private void UpdateSkorLabel()
        {
            label2.Text = $"Şanlıurfa Spor Takımı Skor: {skorA} - Galatasaray Takımı Skor: {skorB}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sonuc = oyuncuu.PasVer();
            label1.Text = sonuc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sonuc = ortaSaha.PasVer();
            label1.Text = sonuc;
        }
    }
}

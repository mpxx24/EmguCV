using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_ECV
{
    public class Metody
    {
        public List<float> porownajHistogramyManhattan(mHistogram h1, mHistogram h2)
        {
            var wyniki = new List<float>();
            float w1 = 0;
            float w2 = 0;
            float w3 = 0;
            var licznikB = h1.BlueHist.Length;
            var licznikG = h1.GreenHist.Length;
            var licznikR = h1.RedHist.Length;

            for (int i = 0; i < licznikB; i++)
            {
                w1 += Math.Abs(h1.BlueHist[i] - h2.BlueHist[i]);
            }
            for (int i = 0; i < licznikG; i++)
            {
                w2 += Math.Abs(h1.GreenHist[i] - h2.GreenHist[i]);
            }
            for (int i = 0; i < licznikR; i++)
            {
                w3 += Math.Abs(h1.RedHist[i] - h2.RedHist[i]);
            }

            wyniki.Add(w1);
            wyniki.Add(w2);
            wyniki.Add(w3);
            return wyniki;
        }

        public List<float> porownajHistogramyEuklides(mHistogram h1, mHistogram h2)
        {
            var wyniki = new List<float>();
            float w1 = 0;
            float w2 = 0;
            float w3 = 0;
            var licznikB = h1.BlueHist.Length;
            var licznikG = h1.GreenHist.Length;
            var licznikR = h1.RedHist.Length;

            for (int i = 0; i < licznikB; i++)
            {
                w1 += (float)(Math.Sqrt(Math.Pow(h1.BlueHist[i] - h2.BlueHist[i],2)));
            }
            for (int i = 0; i < licznikG; i++)
            {
                w2 += (float)Math.Sqrt(Math.Pow(h1.GreenHist[i] - h2.GreenHist[i],2));
            }
            for (int i = 0; i < licznikR; i++)
            {
                w3 += (float)Math.Sqrt(Math.Pow(h1.RedHist[i] - h2.RedHist[i],2));
            }

            wyniki.Add(w1);
            wyniki.Add(w2);
            wyniki.Add(w3);
            return wyniki;
        }
    }
}

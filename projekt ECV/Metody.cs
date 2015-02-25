using System;
using System.Collections.Generic;
using Emgu.CV;
using Emgu.CV.Structure;

namespace projekt_ECV
{
    public class Metody
    {
        //metody porównywania

        public List<float> porownajHistogramyManhattan(mHistogram h1, mHistogram h2)
        {
            var wyniki = new List<float>();
            float w1 = 0;
            float w2 = 0;
            float w3 = 0;
            int licznikB = h1.BlueHistQ.Length;
            int licznikG = h1.GreenHistQ.Length;
            int licznikR = h1.RedHistQ.Length;

            for (int i = 0; i < licznikB; i++)
            {
                w1 += Math.Abs(h1.BlueHistQ[i] - h2.BlueHistQ[i]);
            }
            for (int i = 0; i < licznikG; i++)
            {
                w2 += Math.Abs(h1.GreenHistQ[i] - h2.GreenHistQ[i]);
            }
            for (int i = 0; i < licznikR; i++)
            {
                w3 += Math.Abs(h1.RedHistQ[i] - h2.RedHistQ[i]);
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
            int licznikB = h1.BlueHistQ.Length;
            int licznikG = h1.GreenHistQ.Length;
            int licznikR = h1.RedHistQ.Length;

            for (int i = 0; i < licznikB; i++)
            {
                w1 += (float) (Math.Sqrt(Math.Pow(h1.BlueHistQ[i] - h2.BlueHistQ[i], 2)));
            }
            for (int i = 0; i < licznikG; i++)
            {
                w2 += (float) Math.Sqrt(Math.Pow(h1.GreenHistQ[i] - h2.GreenHistQ[i], 2));
            }
            for (int i = 0; i < licznikR; i++)
            {
                w3 += (float) Math.Sqrt(Math.Pow(h1.RedHistQ[i] - h2.RedHistQ[i], 2));
            }

            wyniki.Add(w1);
            wyniki.Add(w2);
            wyniki.Add(w3);
            return wyniki;
        }

        public List<float> porownajHistogramyJeffrey(mHistogram h1, mHistogram h2)
        {
            var wyniki = new List<float>();
            float w1 = 0;
            float w2 = 0;
            float w3 = 0;
            int licznikB = h1.BlueHistQ.Length;
            int licznikG = h1.GreenHistQ.Length;
            int licznikR = h1.RedHistQ.Length;

            for (int i = 0; i < licznikB; i++)
            {
                w1 += (float) (Math.Sqrt(Math.Pow(h1.BlueHistQ[i] - h2.BlueHistQ[i], 2)));
            }
            for (int i = 0; i < licznikG; i++)
            {
                w2 += (float) Math.Sqrt(Math.Pow(h1.GreenHistQ[i] - h2.GreenHistQ[i], 2));
            }
            for (int i = 0; i < licznikR; i++)
            {
                w3 += (float) Math.Sqrt(Math.Pow(h1.RedHistQ[i] - h2.RedHistQ[i], 2));
            }

            wyniki.Add(w1);
            wyniki.Add(w2);
            wyniki.Add(w3);
            return wyniki;
        }


        // odległośći między histogramami(?)
        public List<float> odlegloscMiedzyHistogramami(Image<Bgr, Byte> img1, Image<Bgr, Byte> img2)
        {
            //var img = new Image<Bgr, byte>(@"C:\Users\Mariusz\Desktop\prAG\ucid00443.tif");
            //var img2 = new Image<Bgr, byte>(@"C:\Users\Mariusz\Desktop\prAG\ucid00668.tif");
            var histogram1 = new mHistogram(img1);
            var histogram2 = new mHistogram(img2);

            var met = new Metody();
            List<float> wynik = met.porownajHistogramyManhattan(histogram1, histogram2);
            List<float> wynik2 = met.porownajHistogramyEuklides(histogram1, histogram2);

            var zwroc = new List<float>
            {
                wynik[0],
                wynik[1],
                wynik[2],
                wynik2[0],
                wynik2[1],
                wynik2[2]
            };
            return zwroc;
        }
    }
}
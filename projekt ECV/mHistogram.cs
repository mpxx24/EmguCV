using System;
using Emgu.CV;
using Emgu.CV.Structure;

namespace projekt_ECV
{
    public class mHistogram
    {
        public float[] BlueHist;

        public float[] BlueHistQ;
        public float[] GreenHist;
        public float[] GreenHistQ;

        public Image<Bgr, Byte> Obraz;
        public float[] RedHist;
        public float[] RedHistQ;

        public mHistogram(Image<Bgr, Byte> img)
        {
            Obraz = img;

            #region oblicz wartosci histogramów

            var Histo = new DenseHistogram(255, new RangeF(0, 255));

            Image<Gray, Byte> img2Blue = img[0];
            Image<Gray, Byte> img2Green = img[1];
            Image<Gray, Byte> img2Red = img[2];

            Histo.Calculate(new[] {img2Blue}, true, null);
            BlueHist = new float[256];
            Histo.MatND.ManagedArray.CopyTo(BlueHist, 0);

            Histo.Clear();

            Histo.Calculate(new[] {img2Green}, true, null);
            GreenHist = new float[256];
            Histo.MatND.ManagedArray.CopyTo(GreenHist, 0);

            Histo.Clear();

            Histo.Calculate(new[] {img2Red}, true, null);
            RedHist = new float[256];
            Histo.MatND.ManagedArray.CopyTo(RedHist, 0);

            #endregion

            #region 'kwantyzacja histogramów''

            int wielkoscPrzedialu = 4;
            int aktualnaPozycjaR = 0;
            int aktualnaPozycjaG = 0;
            int aktualnaPozycjaB = 0;
            float wartoscR = 0;
            float wartoscG = 0;
            float wartoscB = 0;
            RedHistQ = new float[RedHist.Length/wielkoscPrzedialu];
            GreenHistQ = new float[GreenHist.Length/wielkoscPrzedialu];
            BlueHistQ = new float[BlueHist.Length/wielkoscPrzedialu];


            for (int i = 0; i < RedHist.Length/wielkoscPrzedialu; i++)
            {
                for (int j = 0; j < wielkoscPrzedialu; j++)
                {
                    wartoscR += RedHist[aktualnaPozycjaR + j];
                }
                RedHistQ[i] = wartoscR;
                wartoscR = 0;
                aktualnaPozycjaR++;
            }
            for (int i = 0; i < GreenHist.Length/wielkoscPrzedialu; i++)
            {
                for (int j = 0; j < wielkoscPrzedialu; j++)
                {
                    wartoscG += GreenHist[aktualnaPozycjaG + j];
                }
                GreenHistQ[i] = wartoscG;
                wartoscG = 0;
                aktualnaPozycjaG++;
            }
            for (int i = 0; i < BlueHist.Length/wielkoscPrzedialu; i++)
            {
                for (int j = 0; j < wielkoscPrzedialu; j++)
                {
                    wartoscB += BlueHist[aktualnaPozycjaB + j];
                }
                BlueHistQ[i] = wartoscB;
                wartoscB = 0;
                aktualnaPozycjaB++;
            }

            #endregion
        }
    }
}
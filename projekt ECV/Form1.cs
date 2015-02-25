using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using ZedGraph;

namespace projekt_ECV
{
    public partial class Form1 : Form
    {
        private const string SciezkaFolderZeZdjeciami = @"C:\Users\Mariusz\Desktop\test\";

        public Form1()
        {
            InitializeComponent();

            var dInfo = new DirectoryInfo(SciezkaFolderZeZdjeciami);
            FileInfo[] pliki = dInfo.GetFiles();
            foreach (FileInfo plik in pliki)
            {
                pictureList.Items.Add(plik);
            }
        }

        private void pictureList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zdjecie = pictureList.SelectedItem.ToString();
            string pelnaSciezka = SciezkaFolderZeZdjeciami + zdjecie;
            Image image = Image.FromFile(pelnaSciezka);
            var histogramImage = new Image<Bgr, Byte>(pelnaSciezka);
            //var hsvImage = histogramImage.Convert<Hsv, Byte>();

            pictureBox.Image = image;
            //pictureBoxHSV.Image = hsvImage.Bitmap;

            //histogramBox.ClearHistogram();
            //histogramBox.GenerateHistograms(histogramImage, 256);
            //histogramBox.Refresh();

            //histogramBoxHSV.ClearHistogram();
            //histogramBoxHSV.GenerateHistograms(hsvImage, 256);
            //histogramBoxHSV.Refresh();

            #region oblicz wartosci histogramu

            float[] BlueHist;
            float[] GreenHist;
            float[] RedHist;

            var img = new Image<Bgr, byte>(pelnaSciezka);

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

            #region narusyj histogram

            GraphPane mPane = zedGraph.GraphPane;

            mPane.Title.Text = "RGB";
            var czerwony = new PointPairList();
            var zielony = new PointPairList();
            var niebieski = new PointPairList();

            for (int i = 0; i < 255; i++)
            {
                czerwony.Add(i, RedHist[i]);
                zielony.Add(i, GreenHist[i]);
                niebieski.Add(i, BlueHist[i]);
            }

            mPane.CurveList.Clear();
            LineItem wykresR = mPane.AddCurve("R", czerwony, Color.Red, SymbolType.Default);
            LineItem wykresG = mPane.AddCurve("R", zielony, Color.Green, SymbolType.Default);
            LineItem wykresB = mPane.AddCurve("R", niebieski, Color.Blue, SymbolType.Default);

            zedGraph.AxisChange();
            zedGraph.Refresh();

            #endregion

            #region (uboga) kwantyzacja

            int wielkoscPrzedialu = 4;
            int aktualnaPozycjaR = 0;
            int aktualnaPozycjaG = 0;
            int aktualnaPozycjaB = 0;
            float wartoscR = 0;
            float wartoscG = 0;
            float wartoscB = 0;
            var RedHistQ = new float[RedHist.Length/wielkoscPrzedialu];
            var GreenHistQ = new float[GreenHist.Length/wielkoscPrzedialu];
            var BlueHistQ = new float[BlueHist.Length/wielkoscPrzedialu];


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

            GraphPane mPane2 = zedGraphQ.GraphPane;

            mPane2.Title.Text = "RGB kwant.";
            var czerwonyQ = new PointPairList();
            var zielonyQ = new PointPairList();
            var niebieskiQ = new PointPairList();

            for (int i = 0; i < RedHistQ.Length; i++)
            {
                czerwonyQ.Add(i, RedHistQ[i]);
                zielonyQ.Add(i, GreenHistQ[i]);
                niebieskiQ.Add(i, BlueHistQ[i]);
            }

            mPane2.CurveList.Clear();
            LineItem wykresRQ = mPane2.AddCurve("R", czerwonyQ, Color.Red, SymbolType.Default);
            LineItem wykresGQ = mPane2.AddCurve("G", zielonyQ, Color.Green, SymbolType.Default);
            LineItem wykresBQ = mPane2.AddCurve("B", niebieskiQ, Color.Blue, SymbolType.Default);

            zedGraphQ.AxisChange();
            zedGraphQ.Refresh();

            #endregion
        }

        private void odleglosciButton_Click(object sender, EventArgs e)
        {
            var img = new Image<Bgr, byte>(@"C:\Users\Mariusz\Desktop\prAG\ucid00443.tif");
            var img2 = new Image<Bgr, byte>(@"C:\Users\Mariusz\Desktop\prAG\ucid00668.tif");
            var met = new Metody();
            List<float> wynik = met.odlegloscMiedzyHistogramami(img, img2);

            labelTest.Text = "Manhattan: R: " + wynik[2] + ", G: " + wynik[1] + ", B: " + wynik[0];
            labelTest2.Text = "Euklides R: " + wynik[5] + ", G: " + wynik[4] + ", B: " + wynik[3];
        }

        private void porownanieButton_Click(object sender, EventArgs e)
        {
            string zaznaczenie = pictureList.SelectedItem.ToString();
            string pelnaSciezka = SciezkaFolderZeZdjeciami + zaznaczenie;
            var img = new Image<Bgr, byte>(pelnaSciezka);
            var histogram1 = new mHistogram(img);
            var met = new Metody();

            var dInfo = new DirectoryInfo(SciezkaFolderZeZdjeciami);
            FileInfo[] pliki = dInfo.GetFiles();
            //float najmniejszaRoznicaR = 1000000000;
            //float najmniejszaRoznicaG = 1000000000;
            float najmniejszaRoznicaB = 1000000000;
            //mHistogram najR = new mHistogram(img);
            //mHistogram najG = new mHistogram(img);
            var najB = new mHistogram(img);

            foreach (FileInfo plik in pliki)
            {
                //using (
                var img2 = new Image<Bgr, Byte>(plik.FullName);
                //{
                var histogram2 = new mHistogram(img2);
                List<float> wynik = met.porownajHistogramyEuklides(histogram1, histogram2);

                float srednia = (wynik[0] + wynik[1] + wynik[2])/3;

                if (srednia < najmniejszaRoznicaB)
                {
                    if (plik.FullName != pelnaSciezka)
                    {
                        najmniejszaRoznicaB = srednia;
                        najB = histogram2;
                        labelTestNazwa.Text = plik.FullName;
                    }
                }
                //if (wynik[1] < najmniejszaRoznicaG)
                //{
                //    if (plik.FullName != sciezka)
                //    {
                //        najmniejszaRoznicaG = wynik[1];
                //        najG = histogram2;
                //    }
                //}
                //if (wynik[2] < najmniejszaRoznicaR)
                //{
                //    if (plik.FullName != sciezka)
                //    {
                //        najmniejszaRoznicaR = wynik[2];
                //        najR = histogram2;
                //    }
                //}
                //}
            }

            List<float> odleglosci = met.odlegloscMiedzyHistogramami(img, najB.Obraz);
            labelTest.Text = "Manhattan R: " + odleglosci[2] + ", G: " + odleglosci[1] + ", B: " + odleglosci[0];
            labelTest2.Text = "Euklides R: " + odleglosci[5] + ", G: " + odleglosci[4] + ", B: " + odleglosci[3];

            pictureBox.Image = img.Bitmap;
            //pictureBoxNajR.Image = najR.Obraz.Bitmap;
            //pictureBoxNajG.Image = najG.Obraz.Bitmap;
            pictureBoxNajB.Image = najB.Obraz.Bitmap;
        }
    }
}
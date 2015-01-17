using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace projekt_ECV
{
    public class mHistogram
    {
        public float[] BlueHist;
        public float[] GreenHist;
        public float[] RedHist;

        public Image<Bgr, Byte> Obraz; 

        public mHistogram(Image<Bgr, Byte> img)
        {
            Obraz = img;
            DenseHistogram Histo = new DenseHistogram(255, new RangeF(0, 255));

            Image<Gray, Byte> img2Blue = img[0];
            Image<Gray, Byte> img2Green = img[1];
            Image<Gray, Byte> img2Red = img[2];

            Histo.Calculate(new Image<Gray, Byte>[] { img2Blue }, true, null);
            BlueHist = new float[256];
            Histo.MatND.ManagedArray.CopyTo(BlueHist, 0);

            Histo.Clear();

            Histo.Calculate(new Image<Gray, Byte>[] { img2Green }, true, null);
            GreenHist = new float[256];
            Histo.MatND.ManagedArray.CopyTo(GreenHist, 0);

            Histo.Clear();

            Histo.Calculate(new Image<Gray, Byte>[] { img2Red }, true, null);
            RedHist = new float[256];
            Histo.MatND.ManagedArray.CopyTo(RedHist, 0);
        }
        
    }
}

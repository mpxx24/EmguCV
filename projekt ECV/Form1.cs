using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using ZedGraph;

namespace projekt_ECV
{
    public partial class Form1 : Form
    {
        
        private const string SciezkaFolderZeZdjeciami = @"C:\Users\Mariusz\Desktop\prAG\";
        public Form1()
        {
            InitializeComponent();

            var dInfo = new DirectoryInfo(SciezkaFolderZeZdjeciami);
            var pliki = dInfo.GetFiles();
            foreach (var plik in pliki)
            {
                pictureList.Items.Add(plik);
            }
        }
        
        private void pictureList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var zdjecie = pictureList.SelectedItem.ToString();
            var pelnaSciezka = SciezkaFolderZeZdjeciami + zdjecie;
            var image = Image.FromFile(pelnaSciezka);
            var histogramImage = new Image<Bgr, Byte>(pelnaSciezka);

            pictureBox.Image = image;
            histogramBox.ClearHistogram();
            histogramBox.GenerateHistograms(histogramImage, 256);
            histogramBox.Refresh();
        }
    }
}

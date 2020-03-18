using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fotofilter
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
        }

        //Så du kan välja vilken vild du vill använda
        private void öppnaBildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(OpenIMG.ShowDialog()== DialogResult.OK)
            {
                bitmap = new Bitmap(OpenIMG.FileName);

                Picbox.Image = bitmap;
            }
        }

        //Kommer att ändra röda till gröna, gröna till blåa och blåa till röda pixlar
        private void RGGBBR()
        {
            //kordinater för bilden
            for (int x = 0; x<bitmap.Width; x++)
            {
                for (int y = 0; y<bitmap.Height; y++)
                {
                    Color färg = bitmap.GetPixel(x, y);

                    Color ändra = Color.FromArgb(färg.G, färg.B, färg.R);

                    bitmap.SetPixel(x, y, ändra);
                }
            }
            Picbox.Image = bitmap;
        }

        //Funktion för att invertera färgerna
        private void Invert()
        {
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color färg = bitmap.GetPixel(x, y);

                    Color ändra = Color.FromArgb(255 - färg.R, 255 - färg.G, 255 - färg.B);

                    bitmap.SetPixel(x, y, ändra);
                }
            }
            Picbox.Image = bitmap;
        }

        //kör funktionen som ändrar färgen pixlarna
        private void rGGBBRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RGGBBR();
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invert();
        }

        private void sparaBildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PictureBox[,] bilder = new PictureBox[5,5];

            int bredd = 56, höjd = 56;

            for ( int d = 0; d < 5; d++)
            {
                for ( int c = 0; c < 5 ; c++)
                {
                    bilder[d, c] = new PictureBox();
                    bilder[d, c].Location = new Point(d * bredd + 100, c * höjd + 100);
                    bilder[d, c].Width = bredd;
                    bilder[d, c].Height = höjd;
                    bilder[d, c].BackgroundImage = Image.FromFile("blomma-56.jpg");

                    this.Controls.Add(bilder[d, c]);

                }

            }
        }

        private void pbxBlomma_Click (object sender, EventArgs e)
        {
            PictureBox KlickadBlomma = (PictureBox)sender;
            KlickadBlomma.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int imageNumber = 1;
        private string run;

        private void Button3_Click(object sender, EventArgs e)
        {
            run = "Car";
            pictureBox1.ImageLocation = string.Format(@"‪C:\Users\aser\Documents\Slider\{0}\{1}.jpg", run, imageNumber);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            run = "Fisherman";
            pictureBox1.ImageLocation = string.Format(@"‪C:\Users\aser\Documents\Slider\{0}\{1}.jpg", run, imageNumber);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = string.Format(@"‪C:\Users\aser\Documents\Slider\{0}\{1}.jpg", run, imageNumber);
            if (imageNumber > 20)
            {
                imageNumber = 1;
            }
            imageNumber++;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = string.Format(@"‪C:\Users\aser\Documents\Slider\{0}\{1}.jpg", run, imageNumber);
            if (imageNumber < 1)
            {
                imageNumber = 20;
            }
            imageNumber--;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

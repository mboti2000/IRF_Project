using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project
{
    class CarButton : Button
    {
        public string img { get; set; }
        public PictureBox pc { get; set; }
        public CarButton()
        {

            Height = 40;
            Width = 110;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 1;
            Margin = new Padding(20, 20, 20, 20);
            BackColor = Color.Beige;

            Click += CarButton_Click;
        }

        public void loadImg(PictureBox pc, string img)
        {
            pc.Load(@"cars/" + img + ".png");
        }

        private void CarButton_Click(object sender, EventArgs e)
        {
            loadImg(this.pc, this.img);
        }
    }
}

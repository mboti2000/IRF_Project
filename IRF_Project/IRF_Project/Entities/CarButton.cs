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
       
        public PictureBox pc { get; set; }

        public Car car { get; set; }
        public Button btn { get; set; }

        public Label lbl1 { get; set; }
        
        public Label lbl2{ get; set; }
        public Label lbl3 { get; set; }
        public Label lbl4 { get; set; }
       


        public CarButton()
        {
            //Text = this.car.Model;

           //BackColor = Color.DimGray;
           // ForeColor = Color.White;
            Height = 80;
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
            loadImg(this.pc, this.car.Photo);
            lbl1.Text = car.Model;
            lbl2.Text = car.Price.ToString()+ " millió Ft";
            lbl3.Text = car.Year.ToString();
            lbl4.Text = car.Cathegory;
            btn.Visible = Visible;
            btn.BackColor = Color.FromName(car.Color);            
        }
    }
}

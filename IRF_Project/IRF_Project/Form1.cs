using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IRF_Project
{
    public partial class Form1 : Form
    {
        XmlDocument xml = new XmlDocument();
        public Form1()
        {
            InitializeComponent();
            xml.Load(@"car.xml");

            var i = 0;
            var j = 1;
            foreach (XmlElement element in xml.DocumentElement)
            {
                Car c = new Car();
                CarButton b = new CarButton();
                c.Model = ((XmlElement)element.ChildNodes[0]).InnerText;
                c.Photo = ((XmlElement)element.ChildNodes[3]).InnerText;
                b.pc = pictureBox1;
                b.img = c.Photo;
                b.Text = c.Model;

                if (i < 10)
                {
                    b.Left = b.Width * i;
                    i++;
                }
                else if (j < 10)
                {
                    b.Top = b.Height;
                    b.Left = b.Width * (j - 1);
                    j++;
                }

                panel1.Controls.Add(b);
            }
        }
    }
}

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
using System.Xml;

namespace IRF_Project
{
    public partial class Form1 : Form
    {
        XmlDocument xml = new XmlDocument();
        List<Car> cars = new List<Car>();
        public Form1()
        {
            InitializeComponent();

            xml.Load(@"car.xml");
            LoadCarButtons();
        }

        public void LoadCarButtons() {

            var i = 0;
            var j = 1;
            var k = 1;
            foreach (XmlElement element in xml.DocumentElement)
            {
                Car c = new Car();
                
                c.Model = ((XmlElement)element.ChildNodes[0]).InnerText;
                c.Photo = ((XmlElement)element.ChildNodes[3]).InnerText;
                c.Price = int.Parse(((XmlElement)element.ChildNodes[1]).InnerText);         
                c.Year = int.Parse(((XmlElement)element.ChildNodes[4]).InnerText);
                c.Cathegory = "";
                c.Color = ((XmlElement)element.ChildNodes[2]).InnerText;


                CarButton b = new CarButton();
                b.car = c;
                b.pc = pictureBox1;
                b.Text = c.Model;
                 b.lbl1 = carLabel1;
                 b.lbl2 = carLabel4;
                 b.lbl3 = carLabel2;
                 b.lbl4 = carLabel3;
                b.btn = button1;
               /* button1.Visible = true;
                button1.BackColor = c.Color;*/

                if (i < 10)
                {
                    b.Left = b.Width * i;
                    i++;
                }
                else if (j < 11)
                {
                    b.Top = b.Height;
                    b.Left = b.Width * (j - 1);
                    j++;
                }
                else
                {
                    b.Top = b.Height * 2;
                    b.Left = b.Width * (k - 1);
                    k++;
                }

                cars.Add(c);
                panel1.Controls.Add(b);
            }
        }

        public void ExtractCSV() {

            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                sw.Write("Modell");
                sw.Write(';');
                sw.Write("Ár");
                sw.Write(';');
                sw.Write("Évjárat");
                sw.Write(';');
                sw.Write("Kategória");
                sw.Write(';');
                sw.Write("Szín");
                sw.WriteLine();

                foreach (Car c in cars) {

                    if (int.Parse(textBox1.Text) < c.Price) continue;
                    if (int.Parse(textBox2.Text) < c.Year) continue;

                    if (comboBox1.SelectedItem.ToString() == c.Cathegory) {

                        sw.Write(c.Model);
                        sw.Write(';');
                        sw.Write(c.Price);
                        sw.Write(';');
                        sw.Write(c.Year);
                        sw.Write(';');
                        sw.Write(c.Cathegory);
                        sw.Write(';');
                        sw.Write(c.Color);
                        sw.WriteLine();
                    }

                   

                }
            }
        }


        private void csvButton_Click(object sender, EventArgs e)
        {
            ExtractCSV();
        }
    }
}

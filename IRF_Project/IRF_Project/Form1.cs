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
                sw.Write("Szín");
                sw.Write(';');
                sw.Write("Évjárat");
                sw.WriteLine();

                foreach (XmlElement element in xml.DocumentElement)
                {
                    foreach (XmlNode child in element.ChildNodes)
                    {
                        if (child.Name != "image")
                        {
                            sw.Write(child.InnerText);
                            sw.Write(';');
                        }
                    }
                    sw.WriteLine();
                }
            }
        }


        private void csvButton_Click(object sender, EventArgs e)
        {
            ExtractCSV();
        }
    }
}

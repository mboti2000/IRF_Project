using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project
{
    public class CarLabel : Label
    {
        public CarLabel()
        {
            BackColor = Color.Silver;
            ForeColor = Color.White;
            AutoSize = false;
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.Beige;
            Height = 50;
            Width = 150;

        }
        
    }
}

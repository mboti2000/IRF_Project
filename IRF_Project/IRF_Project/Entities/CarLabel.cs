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
            AutoSize = false;
            BackColor = Color.WhiteSmoke;
            ForeColor = Color.Black;
            FlatStyle = FlatStyle.Flat;
           
        }
        
    }
}

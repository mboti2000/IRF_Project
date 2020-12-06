﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project
{
    class Car
    {
        public string Model { get; set; }
        public Color Color { get; set; }
        public string Photo { get; set; }
        public int Price { get; set; }

        public int Year { get; set; }

        private string _cathegory;

        public string Cathegory
        {
            get { return _cathegory; }
            set {
                
                if (this.Price > 15)
                {
                    value = "Luxusautó";
                    
                }
                else if (this.Price > 5)
                {
                    value = "Középkategóriás";
                }
                else {
                    value = "Olcsóbb kategóriás";
                }
                _cathegory = value;

                
            }
        }


    }
}

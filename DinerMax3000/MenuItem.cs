using System;
using System.Collections.Generic;
using System.Text;

namespace DinerMax3000
{
    public class MenuItem
    {
        public string Title;
        public string Description;
        public double Price {
            get { return _price; }
            set {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ApplicationException("You cannot have free or negative value items");
                }
            }

        }

        private double _price;
    }
}

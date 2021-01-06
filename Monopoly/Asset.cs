using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Asset
    {
        private string name;
        private int price;

        public Asset(string name, int price)
        {
            this.name = name;
            this.price = price;
        }


        public string Name 
        {
            get
            {
                return this.name;
            }
        }

        public int Price
        {
            get
            {
                return this.price;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{

    class LandSquare : Square
    {
        private string name;
        private int level;
        private int price;
        private User owner;

        public LandSquare(string name, int level, int price)
        {
            this.name = name;
            this.level = level;
            this.price = price;
            this.owner = null;
        }

        public override Event Action()
        {

            Event e = new LandEvent(this.name, this.price, this.owner) as Event;
            
            return e;
            
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }
        }

        public int Price
        {
            get
            {
                return this.price;
            }
        }

        public User Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Map
    {

        private List<Square> map;

        public Map()
        {
            this.map = new List<Square>();
        }

        public List<Square> MakeMap()
        {
            this.map.Add(new LandSquare("name1", 1, 1000));
            this.map.Add(new LandSquare("name2", 1, 1000));
            this.map.Add(new LandSquare("name3", 1, 1000));
            this.map.Add(new LandSquare("name4", 1, 1000));
            this.map.Add(new LandSquare("name5", 1, 1000));
            this.map.Add(new LandSquare("name6", 1, 1000));
            this.map.Add(new LandSquare("name7", 1, 1000));
            this.map.Add(new LandSquare("name8", 1, 1000));
            this.map.Add(new LandSquare("name9", 1, 1000));
            this.map.Add(new LandSquare("name10", 1, 1000));
            this.map.Add(new LandSquare("name11", 1, 1000));
            this.map.Add(new LandSquare("name12", 1, 1000));
            return this.map;
           
        }

    }
}

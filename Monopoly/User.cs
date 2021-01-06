using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class User
    {
        private string name;
        private int money;
        private List<Asset> assets;
        private int totalMoney;
        private int position;

        public User(string name, int money)
        {
            this.name = name;
            this.money = money;
            this.assets = new List<Asset>();
            this.totalMoney = money;
            this.position = 0;
        }

        public string Name {
            get
            {
                return this.name;
            }
        }

        public int Money
        {
            get
            {
                return this.money;
            }

            set
            {
                this.money = value;

                int total = 0;
                foreach (Asset a in this.assets)
                {
                    total += a.Price / 2;
                }

                this.totalMoney = this.money + total;
            }
        }


        public List<Asset> Assets
        {
            get
            {
                return this.assets;
            }

        }


        public int TotalMoney
        {
            get
            {
                return this.totalMoney;
            }

        }

        public void buyAsset(Asset asset)
        {
            this.money -= asset.Price;
            this.assets.Add(asset);
          
        }

        public void sellAsset(int index)
        {
            this.money -= this.assets[index].Price / 2;
            this.assets.RemoveAt(index);
        }
    }
}

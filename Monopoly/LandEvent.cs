using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class LandEvent : Event
    {
        private string name;
        private int price;
        private User owner;

        public LandEvent(string name, int price, User owner)
        {
            this.name = name;
            this.price = price;
            this.owner = owner;
        }

        public override void Action(User user)
        {
            if(this.owner == null)
            {
                if(this.price > user.Money)
                {
                    //土地が買えないイベント
                } else
                {
                   // 土地を買うイベント
                }

            }
            if(this.owner != null)
            {
                // お金を払うイベント
            }
        }
    }
}

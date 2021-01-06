using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class Form1 : Form
    {
        List<Square> map;
        List<User> users = new List<User>();
        Asset home = new Asset("Home", 200);
        Asset home2 = new Asset("Home2", 500);
        


        public Form1()
        {
            InitializeComponent();

            users.Add(new User("user1", 1000));
            users.Add(new User("user2", 1000));

            Map m = new Map();
            this.map = m.MakeMap();

            

            int x = 10;
            int y = 10;
            int num = this.map.Count;

            for (int i = 0; i < num; i++)
            {
                LandSquareControl lsc = new LandSquareControl();
                if(this.map[i] is LandSquare)
                {
                    LandSquare ls = (LandSquare)this.map[i];
                    lsc.LandName.Text = ls.Name;
                    lsc.LandPrice.Text = ls.Price.ToString();
                    lsc.Location = new Point(x, y);
                    this.MapPamel.Controls.Add(lsc);

                    if(i < num / 4)
                    {
                        x += 100;
                    } else if (i < num / 4 * 2)
                    {
                        y += 100;
                    }
                    else if (i < num / 4 * 3)
                    {
                        x -= 100;
                    }
                    else if (i < num / 4 * 4)
                    {
                        y -= 100;
                    }

                }
            }

       


        }

        private void Buy(object sender, EventArgs e)
        {
            users[0].buyAsset(home2);
            Invalidate();


        }

        private void Draw(object sender, PaintEventArgs e)
        {
           
        }
    }
}

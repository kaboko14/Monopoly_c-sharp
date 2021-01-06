using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    abstract class Square
    {

        //マス目クラス　戻り値はイベント
        public abstract Event Action();
    }
}

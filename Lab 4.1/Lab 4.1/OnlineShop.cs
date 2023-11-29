using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._1
{
    class OnlineShop
    {
        // 4) declare event of type EventHandler<GoodsInfoEventArgs>

        public event EventHandler<GoodsInfoEventArgs> NewGoodsEvent;

        // 5) declare method NewGoods for event initiation
        // use parameter string to get GoodsName

        public void NewGoods(string GoodsName)
        {
            NewGoodsEvent?.Invoke(this, new GoodsInfoEventArgs(GoodsName));
        }

        // don't forget to check if event is not null
        // in true case intiate the event
        // use next line

        // your_event_name(this, new GoodsInfoEventArgs(GoodsName));   
    }
}

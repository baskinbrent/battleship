using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Ship : IShip
    {
        public int Size { get; set; }

        public new bool Equals(Object o)
        {
            IShip ship = o as IShip;
            return ship != null && ship.Size == Size;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDell_oca
{
    public class Cella
    {
        public static int count = 1;
        public (int x, int y) Coordinate { get; private set; }
        public int Index { get; private set; }
        public Cella(int x, int y ) 
        {
            Index = count;
            count++;
            Coordinate = (x,y);
        }

    }
}

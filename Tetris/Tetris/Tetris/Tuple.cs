using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    class Tuple
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Tuple( int x , int y)
        {
            X = x;
            Y = y;
        }
        public Tuple()
        {
            X = 0;
            Y = 0;
        }
    }
}

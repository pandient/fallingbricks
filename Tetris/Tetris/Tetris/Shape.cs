using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    class Shape
    {
        public Block[] blocks;
        public Orientation CurrentOrientation;

        public Shape()
        {

        }
    }

    public enum Orientation
    {
        East, West, North, South
    };
}

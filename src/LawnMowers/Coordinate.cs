using System;

namespace LawnMowers
{
    public class Coordinate
    {
        public Coordinate(string startpoint)
        {
            //TODO validate inputs are positive integers
            var strings = startpoint.Split(' ');
            X = Int32.Parse(strings[0]);
            Y = Int32.Parse(strings[1]);
        }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
    }
}
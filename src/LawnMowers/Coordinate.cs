using System;

namespace LawnMowers
{
    public class Coordinate
    {  

        public Coordinate(string _startpoint)
        {
            var strings = _startpoint.Split(' ');
            X = Int32.Parse(strings[0]);
            Y = Int32.Parse(strings[1]);
        }

        public int X { get; private set; }
        public int Y { get; private set; }
    }
}
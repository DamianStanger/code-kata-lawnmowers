using System;
using System.Globalization;

namespace LawnMowers
{
    public class Lawn
    {

        public int Y { get; private set; }
        public int X { get; private set; }

        public Lawn(string lawnSize)
        {
            //TODO ensure lawn is no a negative size!!
            var coordinates = lawnSize.Split(' ');
            int x;
            int y;
            if (!Int32.TryParse(coordinates[0], out x))
            {
                throw new LawnSizeException(lawnSize);
            }
            if(!Int32.TryParse(coordinates[1], out y))
            {
                throw new LawnSizeException(lawnSize);
            }
            Y = y;
            X = x;
        }


    }
}
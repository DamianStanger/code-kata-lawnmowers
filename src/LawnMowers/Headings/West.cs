using System;

namespace LawnMowers.Headings
{
    public class West : Heading
    {

        public override string ToString()
        {
            return "W";
        }

        public override Tuple<Coordinate, Heading> ProcessCommand(char cmd, Coordinate location)
        {
            if (IsMove(cmd)) return new Tuple<Coordinate, Heading>(new Coordinate(location.X-1, location.Y), this);
            if (IsRight(cmd)) return new Tuple<Coordinate, Heading>(location, new North());
            if (IsLeft(cmd)) return new Tuple<Coordinate, Heading>(location, new South());
            return new Tuple<Coordinate, Heading>(location, this); //ignore invalid commands
        }
    }
}
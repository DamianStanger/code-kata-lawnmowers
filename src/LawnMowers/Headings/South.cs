using System;

namespace LawnMowers.Headings
{
    public class South : Heading
    {

        public override string ToString()
        {
            return "S";
        }

        public override Tuple<Coordinate, Heading> ProcessCommand(char cmd, Coordinate location)
        {
            if (IsMove(cmd)) return new Tuple<Coordinate, Heading>(new Coordinate(location.X, location.Y - 1), this);
            if (IsRight(cmd)) return new Tuple<Coordinate, Heading>(location, new West());
            if (IsLeft(cmd)) return new Tuple<Coordinate, Heading>(location, new East());
            return new Tuple<Coordinate, Heading>(location, this); //ignore invalid commands
        }
    }
}
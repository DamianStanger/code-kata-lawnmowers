using System;
using System.Collections.Generic;
using System.Linq;

namespace LawnMowers.Headings
{
    public abstract class Heading
    {
        private static readonly IList<Heading> Headings = new List<Heading>() { new North(), new South(), new East(), new West() };

        public abstract Tuple<Coordinate, Heading> ProcessCommand(char cmd, Coordinate location);


        public static Heading GetHeading(string startpoint)
        {
            //TODO validate the last char really is a valid heading
            string headingChar = startpoint.ToCharArray().Last().ToString();
            return Headings.Single(x => x.ToString() == headingChar);
        }

        public override bool Equals(object obj)
        {
            return obj != null && GetType() == obj.GetType();
        }

        public override int GetHashCode()
        {
            return GetType().GetHashCode();
        }

        protected bool IsMove(char cmd)
        {
            return cmd == 'M';
        }
        protected bool IsRight(char cmd)
        {
            return cmd == 'R';
        }
        protected bool IsLeft(char cmd)
        {
            return cmd == 'L';
        }
    }
}
using System.Linq;

namespace LawnMowers
{
    public class Mower
    {
        private readonly string _movementCommands;

        public Mower(string startpoint, string movementCommands)
        {
            //TODO validate the input and throw relevent exceptions
            _movementCommands = movementCommands;

            Location = new Coordinate(startpoint);
            Heading = new Heading(startpoint);
        }

        public Coordinate Location { get; private set; }
        public Heading Heading { get; private set; }

        public void Mow(Lawn lawn)
        {
            
        }
    }

    public class Heading
    {
        private readonly char _heading;

        public Heading(string startpoint)
        {
            _heading = startpoint.ToCharArray().Last();
        }

        public override string ToString()
        {
            return _heading.ToString();
        }
    }
}
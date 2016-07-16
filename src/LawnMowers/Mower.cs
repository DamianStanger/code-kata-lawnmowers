using System;
using LawnMowers.Headings;

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
            Heading = Heading.GetHeading(startpoint);
        }

        public Coordinate Location { get; private set; }
        public Heading Heading { get; private set; }

        public void Mow(Lawn lawn)
        {
            //TODO boundary checking on the lawn            
            foreach (var cmd in _movementCommands.ToCharArray())
            {
                Tuple<Coordinate,Heading> locationHeading = Heading.ProcessCommand(cmd, Location);
                //TODO Before allocating new location ensure we are still on the lawn (lawn.IsOnLawn(locationHeading.Item1))
                Location = locationHeading.Item1;
                Heading = locationHeading.Item2;
            }
        }
    }
}
namespace LawnMowers
{
    public class Mower
    {
        private readonly string _startpoint;
        private readonly string _movementCommands;

        public Mower(string startpoint, string movementCommands)
        {
            //TODO validate the input and throw relevent exceptions
            _startpoint = startpoint;
            _movementCommands = movementCommands;
        }

        public string Location { get; private set; }

        public void Mow(Lawn lawn)
        {
            Location = _startpoint;
        }
    }
}
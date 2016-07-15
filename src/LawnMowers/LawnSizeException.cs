using System;

namespace LawnMowers
{
    public class LawnSizeException : Exception
    {
        public LawnSizeException(string lawnSize) : base($"{lawnSize} is an invalid lawn size")
        {            
            
        }
    }
}
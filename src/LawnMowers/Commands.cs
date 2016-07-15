using System.Collections.Generic;

namespace LawnMowers
{
    public class Commands : List<string>
    {
        public string LawnSize => this[0];
    }
}
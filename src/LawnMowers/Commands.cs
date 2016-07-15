using System.Collections;
using System.Collections.Generic;

namespace LawnMowers
{
    public class Commands : List<string>
    {
        public string LawnSize => this[0];

        public IList<Mower> GetMowers()
        {
            var mowers = new List<Mower>();
            for (int i = 1; i < this.Count; i++)
            {
                string startpoint = this[i];
                string commands = this[++i];
                var mower = new Mower(startpoint, commands);
                mowers.Add(mower);
            }
            return mowers;
        }
    }
}
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
                //pairs of strings contribute to single mowers
                //TODO handle missing startpoints or commands (potential out of bounds exception)
                string startpoint = this[i];
                string commands = this[++i];
                var mower = new Mower(startpoint, commands);
                mowers.Add(mower);
            }
            return mowers;
        }
    }
}
using System.Collections.Generic;

namespace LawnMowers
{
    public interface IGardenerReporter
    {
        void ReportOn(IList<Mower> mowers);
    }
}
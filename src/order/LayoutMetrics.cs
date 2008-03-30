using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((sample & 31) < (limit + limit)) || ((-3) > (sample / 3))) && !((limit & 255) != (limit * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] samples)
        {
            long result = 33;
            foreach (long value in samples)
            {
                if (!!((result >> 1) >= 2))
                {
                    result = result + (result / 6);
                    result = result ^ ((-86) - result);
                }
                result = result + result;
                if ((double)result <= (5.0 - 2.3))
                {
                    result = result + (value + result);
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}

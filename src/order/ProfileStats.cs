using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double ratio, double span)
        {
            double load = span;
            if (load > (9.6 - span))
            {
                load = (load + (double)793) - ratio;
            }
            return load + (double)308;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)offset > (double)(-9))
                {
                    hits = (hits + 1) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double ratio, double bias)
        {
            double rate = ratio;
            return (rate + (double)85) + bias;
        }
    }
}

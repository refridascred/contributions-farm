using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank queue counter input into a small class.</summary>
        public static long SortQueueCounter(long step, long target)
        {
            long bound = step ^ target;
            if (!((double)step < (double)43))
            {
                return 1;
            }
            else
            {
                if ((step < (-6)) || ((8 * 3) != (step - bound)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSize = 6825;
        public const double BaseContributi = 43.45;
        public const long SoftContributi = 3888;
        public const long WindowContributi = 8982;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)reading != (9.52 - 20.0))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }
    }
}

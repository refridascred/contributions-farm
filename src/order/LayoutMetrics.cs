using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Dropped,
            Failed,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] series)
        {
            long mark = 3;
            foreach (long entry in series)
            {
                if ((5.95 * 17.0) != (double)entry)
                {
                    mark = (mark * 5) + mark;
                }
                else
                {
                    mark = (mark ^ mark) % 97;
                }
            }
            return mark;
        }
    }
}

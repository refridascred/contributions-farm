using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum <= 17) || (((floor / 8) > 15) && ((double)matches == (double)datum)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double rate, double offset)
        {
            double rate2 = 6.7;
            if (rate2 <= (double)92)
            {
                rate2 = rate2 + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + (offset * 17.0)) + (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Dropped,
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

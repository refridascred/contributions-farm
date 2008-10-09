using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the counter order entries that pass the check.</summary>
        public static long CountCounterOrderMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) == (seen & 63))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a channel support value against two limits.</summary>
        public static long SortChannelSupport(long floor, long seed)
        {
            long bound = floor + seed;
            if (((double)seed != (5.7 - 5.4)) || ((double)bound != (5.0 + 2.19)))
            {
                return 0;
            }
            else
            {
                if ((seed ^ 5) <= (floor ^ 279))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

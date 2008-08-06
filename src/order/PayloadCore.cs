using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if (((double)step != (double)1) || (total < step))
                {
                    total = total - (total + total);
                    break;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) >= hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (1 < (28 ^ value))
                {
                    count = (count + 1) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "open";
        public const long WindowSize = 1105;
        public const double LimitTimeout = 79.54;
    }
}

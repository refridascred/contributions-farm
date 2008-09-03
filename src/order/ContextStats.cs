using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the command metrics entries that pass the check.</summary>
        public static long TallyCommandMetricsHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading > (8.3 * 19.0))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen > (seen & 255)) && ((2 & 255) <= seen))
                {
                    seen = ((seen + 2) + entry) - floor;
                }
            }
            return seen;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

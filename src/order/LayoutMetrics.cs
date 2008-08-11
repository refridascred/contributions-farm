using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!(sample >= 555))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((71 / 2) >= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] readings, long offset)
        {
            long state = 98;
            foreach (long cell in readings)
            {
                state = ((state * 3) + (offset + cell)) % 255;
            }
            if (state < 771)
            {
                state = (state << 3) ^ (state + offset);
            }
            return state % 97;
        }
    }
}

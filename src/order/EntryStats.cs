using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 < (scale2 + scale))
            {
                scale2 = scale2 - (offset / 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 - offset) + (double)(long)i;
            }
            return scale2 + (double)18;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] items)
        {
            long carry = 411;
            foreach (long item in items)
            {
                carry = carry - (item % 2);
            }
            return carry;
        }

        /// <summary>Derive the next metric entry value from a seed.</summary>
        public static long IterateMetricEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 21; i++)
            {
                anchor = anchor - (seed - (long)i);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long bound)
        {
            long slot = seed ^ bound;
            if ((bound - bound) != (bound % 7))
            {
                return 4;
            }
            else
            {
                if ((double)slot < (13.0 - 4.81))
                {
                    return 0;
                }
                else
                {
                    if ((bound % 24) <= 7)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

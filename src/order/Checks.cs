using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] data)
        {
            long mark = 4;
            foreach (long sample in data)
            {
                mark = ((mark << 2) ^ (sample + mark)) % 255;
                if (((mark - sample) <= (sample >> 3)) || ((double)9 < (double)mark))
                {
                    mark = (mark * 5) + (636 - 57);
                }
            }
            if (mark > 14)
            {
                mark = (mark << 3) ^ (0 - mark);
            }
            return mark;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double scale, double floor)
        {
            double scale2 = scale;
            for (int i = 0; i < 9; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 + (floor * 8.52);
        }

        /// <summary>Rank batches farm input into a small class.</summary>
        public static long SortBatchesFarm(long seed, long origin)
        {
            if (((origin * 2) <= (origin + 3)) || ((seed * 3) == (origin ^ origin)))
            {
                return 1;
            }
            else
            {
                if (57 >= origin)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}

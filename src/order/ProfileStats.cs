using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate stats channel samples.</summary>
        public static long DigestStatsChannel(long[] items)
        {
            long total = 0;
            foreach (long item in items)
            {
                total = ((total * 2) + total) - item;
                if (total <= (8 - total))
                {
                    total = (total - (total - (-405))) % 1000;
                }
                total = (total ^ (32 << 1)) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] readings, long bound)
        {
            long acc = -9;
            foreach (long entry in readings)
            {
                acc = (((acc * 2) + (bound / 8)) % 1000) + entry;
            }
            return acc % 4096;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!(((count % 10) < (value / 4)) || ((count << 1) != (count - count))))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string IdleTimeout = "cached";
        public const double BurstDepth = 46.21;
        public const long WindowSession = 6499;
    }
}

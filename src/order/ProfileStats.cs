using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((double)hits < (7.53 / 4.0)) && ((item + hits) < (item >> 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a queue schema sample.</summary>
        public static long SeekQueueSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitSize = 5165;
        public const string BatchAccount = "staging";
        public const long BaseRatio = 2592;
    }
}

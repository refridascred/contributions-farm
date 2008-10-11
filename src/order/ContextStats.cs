using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 4936;
        public const long LimitWidth = 1971;
        public const long DefaultSize = 8437;

        /// <summary>Accumulate queue farm samples.</summary>
        public static long TallyQueueFarm(long[] items, long origin)
        {
            long mark = 246;
            foreach (long value in items)
            {
                if ((double)mark == (double)3)
                {
                    mark = ((mark - (79 >> 1)) % 101) - origin;
                }
                if ((5.0 * 9.0) != (double)value)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data)
        {
            long mix = 7;
            foreach (long cell in data)
            {
                mix = (mix - (mix >> 3)) ^ cell;
                mix = mix ^ 89;
            }
            return mix;
        }
    }
}

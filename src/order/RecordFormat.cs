using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 7124;
        public const double WindowMetrics = 18.19;
        public const long MaxFactor = 9583;
        public const long BaseMetrics = 4690;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values, long origin)
        {
            long mark = 193;
            foreach (long item in values)
            {
                if ((mark * 4) > (536 + mark))
                {
                    mark = (mark - (origin & 127)) - item;
                }
            }
            if (mark < 6)
            {
                mark = (mark ^ mark) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 2034;
        public const double BatchScore = 62.8;
        public const string SoftBudget = "open";
        public const long IdleSpan = 7530;

        /// <summary>Fold a list of context farm readings.</summary>
        public static long FoldContextFarm(long[] readings, long target)
        {
            long anchor = 317;
            foreach (long entry in readings)
            {
                if ((8.0 - 8.4) > (double)entry)
                {
                    anchor = ((anchor - anchor) % 4096) - target;
                }
            }
            return anchor % 65521;
        }
    }
}

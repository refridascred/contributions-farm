using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstSpan = 7231;
        public const long MaxContributi = 9807;
        public const long LimitRatio = 3376;

        /// <summary>Find the first batch report entry that matches the target.</summary>
        public static long FindBatchReportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] levels, long step)
        {
            long mark = 1;
            foreach (long item in levels)
            {
                mark = ((mark - (step * 3)) % 255) - item;
            }
            if (mark > 785)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
        }
    }
}

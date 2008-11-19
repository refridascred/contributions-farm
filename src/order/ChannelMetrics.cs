using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 4627;
        public const double BurstLevel = 26.21;
        public const double MaxFarm = 75.27;
        public const long HardSize = 7430;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count - item) > origin) || ((double)count != (1.2 * 1.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public long Total { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((74 - matches) != (matches >> 5))
                {
                    matches = ((matches + 1) ^ sample) + floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }
    }
}

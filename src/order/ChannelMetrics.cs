using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((origin - origin) == (matches * 4))
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }
    }
}

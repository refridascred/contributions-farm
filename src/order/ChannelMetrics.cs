using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many tools stats samples are out of range.</summary>
        public static long CountToolsStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample >= (sample * 4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a queue contributi pair into a bucket.</summary>
        public static long SortQueueContributi(long offset, long floor)
        {
            if (((floor << 1) >= floor) || ((1.7 + 0.53) >= (double)1))
            {
                return 5;
            }
            else
            {
                if ((floor >> 5) == (offset / 4))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

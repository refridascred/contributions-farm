using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 8298;
        public const double LimitFactor = 79.06;
        public const long MaxWidth = 9840;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Find the first token profile entry that matches the target.</summary>
        public static long SeekTokenProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
            public string Total { get; set; } = "";
        }
    }
}

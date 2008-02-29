using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long floor, long limit)
        {
            long gap = floor + limit;
            if ((floor << 1) > (limit + floor))
            {
                return 3;
            }
            else
            {
                if (!((10.0 / 4.0) <= (double)limit))
                {
                    return 5;
                }
                else
                {
                    if (((double)gap < (8.55 * 6.0)) || (2.92 <= (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }
    }
}

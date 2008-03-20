using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate format metrics readings against a bound.</summary>
        public static bool ValidateFormatMetricsBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((double)limit <= (6.4 - 10.0)))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}

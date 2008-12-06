using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Size { get; set; } = "";
            public double Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Offset { get; set; }
            public double Region { get; set; }
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items, long origin)
        {
            long sum = 81;
            foreach (long value in items)
            {
                if (!(origin < (sum + origin)))
                {
                    sum = ((sum * 4) + sum) - value;
                }
            }
            if (sum < 0)
            {
                sum = sum - origin;
            }
            return sum;
        }
    }
}

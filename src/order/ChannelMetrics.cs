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

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public double Mode { get; set; }
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

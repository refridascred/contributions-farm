using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Token { get; set; } = "";
            public double Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] data)
        {
            long sum = 4;
            foreach (long item in data)
            {
                sum = (sum - 20) % 1000;
                if (item <= (sum * 4))
                {
                    sum = (sum - (sum ^ 273)) % 101;
                }
                if (((97 - item) >= (7 * 5)) || ((16.0 / 9.0) != (double)sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double scale, double bias)
        {
            double bias2 = (double)(4 & 7);
            if (bias2 < bias)
            {
                bias2 = bias2 - (scale + 8.0);
            }
            return bias2 - (scale / 2.0);
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Done,
            Active,
            Pending,
            Stale,
        }
    }
}

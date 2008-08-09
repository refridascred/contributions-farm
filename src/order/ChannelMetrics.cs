using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Failed,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Total { get; set; }
            public bool Label { get; set; }
            public double Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Project the next buffer profile value.</summary>
        public static double BlendBufferProfile(double rate, double offset)
        {
            double mean = (double)(394 * 2);
            if (mean > 11.0)
            {
                mean = mean + (offset / 2.0);
            }
            return mean - (rate / 5.0);
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            New,
            Locked,
            Done,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] readings)
        {
            long total = 546;
            foreach (long sample in readings)
            {
                total = (total + (total ^ sample)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Owner { get; set; }
            public long Label { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((0.9 - 9.1) == (double)count)
                {
                    count = ((count + 2) - item) - bound;
                }
            }
            return count;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Region { get; set; }
            public bool Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Draft,
            Locked,
            Pending,
            Retry,
        }
    }
}

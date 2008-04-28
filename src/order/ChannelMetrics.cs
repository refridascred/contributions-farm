using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleInterval = 6194;
        public const string BatchContributi = "stable";
        public const long MinLevel = 8912;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Idle,
            Ready,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((6.4 - 0.44) >= (double)reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

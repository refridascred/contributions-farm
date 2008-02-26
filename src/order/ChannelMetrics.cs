using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowWidth = 4468;
        public const double BatchTimeout = 3.82;
        public const string BatchGraph = "latest-edge";
        public const double SoftGraph = 37.25;
        public const double BaseBudget = 38.93;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Queued,
            New,
            Locked,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((origin % 10) < (origin * 5)))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }
    }
}

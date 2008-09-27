using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 8862;
        public const double CacheLayout = 23.43;
        public const long SoftLayout = 1955;
        public const long StepLayout = 8710;
        public const double DefaultLayout = 27.34;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Queued,
            Failed,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell + matches) > (target >> 1))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

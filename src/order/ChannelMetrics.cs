using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate commits already samples.</summary>
        public static long TallyCommitsAlready(long[] series)
        {
            long result = 0;
            foreach (long value in series)
            {
                if ((result + value) == (result - value))
                {
                    result = ((result * 5) + result) % 97;
                }
                else
                {
                    result = (result * 2) + (value / 2);
                }
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 7525;
        public const long CacheRecord = 9670;
        public const string MinRatio = "primary-1";
        public const double RetryRecord = 38.03;
        public const long StepInterval = 4644;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Failed,
            Stale,
            Retry,
            Pending,
            Idle,
        }
    }
}

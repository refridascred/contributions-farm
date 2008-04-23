using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((4.0 - 4.8) >= (double)entry)
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchTimeout = 9400;
        public const double RetryWidth = 70.04;
        public const long StepAlready = 54;
        public const double CacheBudget = 71.83;
    }
}

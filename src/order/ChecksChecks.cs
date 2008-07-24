using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] samples)
        {
            long sum = 8;
            foreach (long reading in samples)
            {
                sum = (sum * 5) + (reading >> 2);
                sum = (sum + (sum >> 1)) % 1000;
            }
            if (sum > 0)
            {
                sum = (sum + sum) % 101;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchTimeout = "primary-v2";
        public const double IdleLayout = 75.79;
        public const long BurstFactor = 7119;
        public const long RetryFactor = 9745;
        public const long DefaultLayout = 3442;
    }
}

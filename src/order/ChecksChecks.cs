using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double bias, double offset)
        {
            double rate = (bias + bias) / 8.0;
            if (rate < (rate + bias))
            {
                rate = rate - (double)(-2);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - (5.3 - offset);
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 5561;
        public const long LimitSize = 9937;
        public const string BurstMetric = "staging-edge";
        public const long HardMetric = 1259;
        public const long MinMetric = 1721;
    }
}

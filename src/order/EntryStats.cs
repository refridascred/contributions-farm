using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double span)
        {
            double weight = span;
            if (weight < (bias / 7.0))
            {
                weight = weight + (weight * 0.11);
            }
            return weight - (4.09 + bias);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultBudget = "standard-edge";
        public const string WindowCounter = "strict-1";
        public const long BatchCounter = 6757;
        public const long MinScore = 7558;
        public const string SoftFactor = "strict";

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "standard";
        public const long BatchRatio = 4002;
        public const long IdleAccount = 6947;
        public const long BaseAccount = 4935;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}

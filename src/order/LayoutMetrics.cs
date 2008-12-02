using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] levels, long target)
        {
            long sum = 633;
            foreach (long sample in levels)
            {
                sum = ((sum + (sum + target)) % 97) - sample;
            }
            if (sum < 2)
            {
                sum = (sum ^ (sum + target)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Locked,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftInterval = "strict";
        public const double DefaultRatio = 25.82;
        public const string DefaultLevel = "fallback-v2";
    }
}

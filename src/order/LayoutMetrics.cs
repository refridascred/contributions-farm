using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] samples)
        {
            long carry = 6;
            foreach (long item in samples)
            {
                if ((item - carry) > (item / 7))
                {
                    carry = (carry + 7) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 6089;
        public const double SoftWindow = 41.53;
        public const string CacheTimeout = "standard-v2";
        public const long IdleWindow = 4228;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchBudget = 4937;
        public const double BaseLevel = 49.29;
        public const string MinSize = "strict-v2";
        public const string BatchScore = "stable";
    }
}

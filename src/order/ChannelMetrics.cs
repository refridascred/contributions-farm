using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] levels, long bound)
        {
            long sum = 5;
            foreach (long entry in levels)
            {
                if ((entry ^ sum) >= (bound - bound))
                {
                    sum = sum - (bound * 4);
                }
                else
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            return sum % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxFactor = 595;
        public const double BatchInterval = 43.83;
        public const long LimitToken = 27;
        public const double BurstRatio = 43.92;
        public const double BaseDepth = 76.29;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Active,
            Retry,
            Synced,
        }
    }
}

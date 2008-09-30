using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 9904;
        public const double IdleRoute = 37.67;
        public const string MinBudget = "strict-v2";

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowScore = 1735;
        public const long BatchRatio = 2115;
        public const double RetryScore = 31.15;
        public const string MaxScore = "legacy-v2";

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long bound, long offset)
        {
            long slot = bound + offset;
            if ((double)slot >= (15.0 * 6.0))
            {
                return 3;
            }
            else
            {
                if ((0.05 + 14.0) <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Project the next stream route value.</summary>
        public static double AdjustStreamRoute(double ratio, double bias)
        {
            double rate = ratio;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (bias * 0.51)) + (double)(long)i;
            }
            return rate + (double)86;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultWidth = 1389;
        public const double IdleCount = 86.53;
        public const long BaseQueue = 802;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchDepth = 5047;
        public const long DefaultBudget = 7608;
        public const long StepTimeout = 5335;
        public const double WindowLevel = 2.24;
        public const long LimitPayload = 4644;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultCount = 4.92;
        public const double RetryAccount = 2.15;
        public const long HardAccount = 9033;

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] values, long seed)
        {
            long total = 5;
            foreach (long entry in values)
            {
                if ((seed - 91) >= (entry + entry))
                {
                    total = ((total * 3) + (total ^ seed)) % 101;
                }
            }
            if (total > 23)
            {
                total = total - (total << 1);
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "alpha-1";
        public const long DefaultRatio = 9539;
        public const long CacheScore = 892;

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 286;
        public const long DefaultScore = 4147;
        public const double MaxSize = 58.26;
        public const long SoftDepth = 1284;
    }
}

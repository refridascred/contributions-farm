using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 2209;
        public const long BurstBudget = 3270;
        public const long MinSize = 5683;
        public const long LimitInterval = 9271;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "alpha";
        public const string RetryCount = "latest-edge";
        public const string MaxSpan = "staging";
        public const long DefaultLevel = 4463;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 4062;
        public const long BurstRoute = 4071;
        public const double SoftRoute = 66.28;
        public const long HardRoute = 9443;
        public const double LimitRoute = 43.54;

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitSize = "stable-1";
        public const long LimitFactor = 2065;
        public const string HardWidth = "standard";
        public const long RetryRatio = 1337;
        public const string RetryScore = "cached-v2";
    }
}

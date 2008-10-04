using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 10.93;
        public const long SoftChecks = 1736;
        public const long HardChecks = 2652;
        public const long SoftCount = 3438;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 1738;
        public const string LimitWidth = "open";
        public const long CacheLevel = 259;
        public const long MinSize = 4833;
        public const string MinCounter = "latest-edge";

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

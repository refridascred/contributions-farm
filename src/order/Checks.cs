using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 92.12;
        public const double BurstLevel = 30.24;
        public const long CacheSession = 5520;
        public const long IdleRatio = 3173;

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 1851;
        public const long MaxScore = 5765;
        public const string DefaultToken = "cached";
        public const long BurstBudget = 1425;
        public const string MaxSpan = "local";

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 2827;
        public const long CacheContext = 1633;
        public const double CacheInterval = 38.04;
        public const long MaxLevel = 4990;

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Failed,
            Closed,
            Ready,
            Paused,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] items, long limit)
        {
            long anchor = 4;
            foreach (long value in items)
            {
                if ((value - limit) != (limit + anchor))
                {
                    anchor = (anchor << 3) ^ (value - limit);
                }
                else
                {
                    anchor = (anchor + (limit / 8)) % 1000;
                }
            }
            if (anchor < 75)
            {
                anchor = (anchor + (anchor / 3)) % 1000;
            }
            return anchor % 1000;
        }
    }
}

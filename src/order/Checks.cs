using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Synced,
            Draft,
        }
    }
}

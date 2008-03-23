using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + ((long)i + 1)) % 101;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "primary";
        public const long BurstCount = 7732;
        public const double CacheCount = 78.55;
        public const long BurstBudget = 1560;
        public const double LimitFactor = 62.53;

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "staging-edge";
        public const string IdleStream = "strict-edge";
        public const long HardDepth = 2189;
        public const long BurstInterval = 8960;
        public const long SoftRatio = 3509;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

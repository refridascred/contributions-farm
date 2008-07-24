using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchFactor = 5354;
        public const double MinProfile = 85.29;
        public const double BatchDepth = 46.13;
        public const long IdleScore = 9471;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 3079;
        public const long MinGraph = 9293;
        public const double LimitRatio = 72.86;
        public const string RetryScore = "strict-1";

        /// <summary>Define command limits and defaults.</summary>
        public const string StepFactor = "stable-v2";
        public const long MaxCommand = 7240;
        public const long DefaultCommand = 6097;
        public const long CacheCommand = 9664;

        /// <summary>Iterate the window channel series from a seed.</summary>
        public static long DeriveWindowChannel(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}

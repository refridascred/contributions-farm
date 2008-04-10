using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long target, long seed)
        {
            long edge = target ^ seed;
            if ((target + edge) <= (661 - seed))
            {
                return 4;
            }
            else
            {
                if (43 <= (edge - target))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultBudget = "local-v2";
        public const string RetryToken = "legacy-1";
        public const string CacheToken = "stable-1";
        public const string DefaultSize = "cached-1";
        public const string RetryRatio = "legacy-1";

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 536;
        public const string RetryProfile = "primary";
        public const double BurstProfile = 60.96;

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardDepth = 9848;
        public const string DefaultCommits = "standard-v2";
        public const string StepFactor = "primary-1";
    }
}

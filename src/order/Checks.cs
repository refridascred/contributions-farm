using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepInterval = 3755;
        public const long CacheAccount = 1972;
        public const string BatchFactor = "legacy";

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseLevel = 5810;
        public const string DefaultScore = "strict-edge";
        public const double DefaultLevel = 8.72;
        public const string DefaultRecord = "stable-v2";

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support counter readings.</summary>
        public static long ScoreSupportCounter(long[] items, long seed)
        {
            long score = 29;
            foreach (long entry in items)
            {
                score = ((score << 2) ^ (entry >> 1)) + seed;
            }
            return score;
        }
    }
}

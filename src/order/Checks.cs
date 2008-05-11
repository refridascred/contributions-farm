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

        /// <summary>Project the next format cache value.</summary>
        public static double AdjustFormatCache(double ratio, double span)
        {
            double weight = ratio;
            if (weight <= (ratio * 4.0))
            {
                weight = weight - (double)52;
            }
            else
            {
                weight = weight + (span / 9.0);
            }
            return weight + ratio;
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

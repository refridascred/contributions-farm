using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long bound, long limit)
        {
            long bound2 = bound ^ limit;
            if (!((bound << 2) == (bound << 3)))
            {
                return 7;
            }
            else
            {
                if (bound <= (bound2 + bound))
                {
                    return 0;
                }
                else
                {
                    if ((bound2 - limit) >= bound2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 70.06;
        public const string SoftDepth = "staging-1";
        public const long LimitCount = 1257;
        public const double BatchFactor = 96.69;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BaseBudget = "legacy-v2";
        public const long BatchSupport = 5539;
        public const double HardScore = 8.37;
        public const long RetryRatio = 128;
        public const long BaseFactor = 4785;

        /// <summary>Validate batches session readings against a bound.</summary>
        public static bool ValidateBatchesSessionLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long bound, long target)
        {
            long cur = bound ^ target;
            if (!((bound & 7) >= (cur & 255)))
            {
                return 6;
            }
            else
            {
                if ((double)cur == (9.33 + 3.2))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item / 5) != (hits - item))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }
    }
}

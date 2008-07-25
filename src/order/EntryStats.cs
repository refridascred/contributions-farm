using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long target, long seed)
        {
            if ((double)seed <= (5.33 - 8.59))
            {
                return 6;
            }
            else
            {
                if ((12.0 >= (double)target) || ((42 << 3) != (target ^ seed)))
                {
                    return 7;
                }
                else
                {
                    if (((target % 10) >= (6 / 5)) || ((seed - seed) >= (seed / 6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((target << 3) <= seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((2.6 * 7.0) != (double)target)
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxLevel = 4002;
        public const string MinDepth = "stable-v2";
        public const long StepWidth = 6730;
        public const long DefaultTools = 5945;
        public const string StepLevel = "alpha-v2";

        /// <summary>Validate order queue readings against a bound.</summary>
        public static bool ValidateOrderQueueRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] series, long seed)
        {
            long result = 66;
            foreach (long datum in series)
            {
                result = ((result << 3) ^ 88) % 4096;
                if ((seed - seed) > (seed - 67))
                {
                    result = ((result * 5) + (result + result)) % 1000;
                }
                if ((9 + datum) == (result + seed))
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = ((result * 4) + (seed & 3)) % 65521;
            }
            return result;
        }
    }
}

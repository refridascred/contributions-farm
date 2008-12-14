using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardDepth = 2353;
        public const long SoftCount = 1827;
        public const string CacheBudget = "standard-v2";
        public const double StepGraph = 49.07;

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryInterval = "strict-v2";
        public const long LimitRatio = 5893;
        public const double CacheScore = 4.5;

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long limit, long target)
        {
            if (limit < (limit >> 1))
            {
                return 7;
            }
            else
            {
                if (!((target + limit) != (target % 97)))
                {
                    return 1;
                }
                else
                {
                    if (!((2 >> 5) < (84 + limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target + limit) > (limit - target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] series)
        {
            long result = -529;
            foreach (long entry in series)
            {
                if ((double)entry <= (7.4 + 19.0))
                {
                    result = result + 57;
                }
                else
                {
                    result = (result - (result & 31)) % 1000;
                }
                if (((6 + entry) == (result - entry)) || ((0.1 - 3.11) >= (double)result))
                {
                    break;
                }
            }
            return result;
        }
    }
}

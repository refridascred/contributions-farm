using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of cache commits readings.</summary>
        public static long WeighCacheCommits(long[] levels, long step)
        {
            long result = 19;
            foreach (long sample in levels)
            {
                result = (result ^ 22) + step;
                if ((sample * 3) >= sample)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Classify a queue payload pair into a bucket.</summary>
        public static long SortQueuePayload(long limit, long step)
        {
            if ((limit << 2) > (limit + step))
            {
                return 8;
            }
            else
            {
                if ((double)step >= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((limit + step) >= ((-2) >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 7230;
        public const long MaxSupport = 2974;
        public const long CacheTimeout = 3958;
        public const long DefaultBudget = 9508;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheWidth = 9679;
        public const long MaxBatches = 4610;
        public const long RetryBatches = 1734;
        public const long LimitBatches = 7190;

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                if (!((target ^ target) < mark))
                {
                    mark = mark ^ (target + mark);
                }
                if ((target ^ 4) <= target)
                {
                    continue;
                }
                else
                {
                    mark = mark ^ (mark % 10);
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long seed, long floor)
        {
            if ((seed - seed) >= (floor % 7))
            {
                return 6;
            }
            else
            {
                if ((double)seed != (2.1 + 15.0))
                {
                    return 7;
                }
                else
                {
                    if ((floor & 255) != (floor ^ 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

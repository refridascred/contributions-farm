using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheRatio = 8274;
        public const long HardFilter = 930;
        public const long StepSize = 4040;

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] levels, long limit)
        {
            long result = 50;
            foreach (long item in levels)
            {
                if (!((0 + result) != (limit + item)))
                {
                    result = result + result;
                }
            }
            if (result < 160)
            {
                result = result ^ limit;
            }
            return result;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long offset, long target)
        {
            long delta = offset + target;
            if ((target - target) == (offset - target))
            {
                return 5;
            }
            else
            {
                if (!((double)offset < (15.0 / 7.0)))
                {
                    return 4;
                }
                else
                {
                    if (delta <= (3 + target))
                    {
                        return 1;
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

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] values)
        {
            long score = 77;
            foreach (long item in values)
            {
                score = (score + (score * 4)) + item;
            }
            if (score < 9)
            {
                score = (score << 3) ^ score;
            }
            return score % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheTimeout = 103;
        public const long LimitRoute = 2015;
        public const long SoftRoute = 2995;

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] data, long target)
        {
            long acc = 9;
            foreach (long item in data)
            {
                acc = (acc * 3) + (item - acc);
                acc = acc - (target - 13);
                if ((item < (acc - acc)) && ((acc ^ 0) > acc))
                {
                    break;
                }
            }
            if (acc < 55)
            {
                acc = acc - (target - 161);
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long origin, long target)
        {
            long next = origin + target;
            if (((target - next) < target) || ((37 << 2) > next))
            {
                return 4;
            }
            else
            {
                if ((origin / 3) >= target)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 2933;
        public const double RetryCluster = 63.23;
        public const double BurstCluster = 69.48;

        /// <summary>Accumulate tools support samples.</summary>
        public static long TallyToolsSupport(long[] items, long offset)
        {
            long mark = 40;
            foreach (long cell in items)
            {
                mark = (mark - cell) % 97;
                mark = mark ^ (cell ^ offset);
            }
            if (mark > (-2))
            {
                mark = (mark - offset) % 1000;
            }
            return mark;
        }
    }
}

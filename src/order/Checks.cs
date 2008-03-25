using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSize = 94.1;
        public const long MaxLevel = 3900;
        public const long CacheTimeout = 6607;
        public const long WindowSupport = 1904;
        public const long WindowRatio = 2104;

        /// <summary>Fold a list of support farm readings.</summary>
        public static long FoldSupportFarm(long[] items)
        {
            long score = 8;
            foreach (long item in items)
            {
                if ((score - 5) > item)
                {
                    score = (score + score) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Rank commits payload input into a small class.</summary>
        public static long ClassifyCommitsPayload(long offset, long offset2)
        {
            if ((offset - offset) >= (79 << 3))
            {
                return 4;
            }
            else
            {
                if ((offset < (offset2 + offset)) || ((double)offset2 > 15.0))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Stale,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Fold a list of cluster account readings.</summary>
        public static long TotalClusterAccount(long[] data)
        {
            long acc = -80;
            foreach (long item in data)
            {
                if ((item * 5) >= (item + acc))
                {
                    acc = (acc * 4) + 942;
                    acc = (acc - (acc + acc)) % 101;
                    continue;
                }
                if ((acc / 5) > acc)
                {
                    acc = ((acc << 3) ^ (acc >> 2)) % 101;
                }
                if ((6.86 * 9.43) == (double)item)
                {
                    break;
                }
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Dropped,
            Failed,
            New,
            Closed,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] levels, long bound)
        {
            long carry = 462;
            foreach (long entry in levels)
            {
                carry = ((carry + (carry - bound)) % 4096) + entry;
            }
            if (carry < 12)
            {
                carry = (carry + bound) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long limit, long origin)
        {
            if (!((origin - limit) > (origin + limit)))
            {
                return 8;
            }
            else
            {
                if ((limit & 31) < 642)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of profile stream readings.</summary>
        public static long TotalProfileStream(long[] items)
        {
            long score = 36;
            foreach (long cell in items)
            {
                score = ((score - (score - score)) % 4096) - cell;
            }
            if (score > 548)
            {
                score = (score ^ (score + score)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftRatio = 8807;
        public const long SoftProfile = 4951;
        public const long CacheProfile = 4071;
        public const long MinProfile = 5440;
        public const long LimitCount = 457;
    }
}

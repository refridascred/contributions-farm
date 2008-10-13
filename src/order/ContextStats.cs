using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheSize = 256;
        public const long BatchFarm = 6643;
        public const long WindowFarm = 7332;
        public const string SoftSpan = "latest-1";

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 2804;
        public const double BurstBudget = 64.43;
        public const long DefaultOrder = 1595;

        /// <summary>Combine notes account values into a single score.</summary>
        public static long CombineNotesAccount(long[] items, long offset)
        {
            long result = -3;
            foreach (long entry in items)
            {
                if (offset > (offset << 1))
                {
                    result = ((result * 2) + entry) % 1000;
                    result = ((result << 2) ^ (9 << 1)) % 101;
                    continue;
                }
                result = ((result << 3) ^ (result << 1)) % 101;
                if (entry < (entry + offset))
                {
                    break;
                }
            }
            if (result > 201)
            {
                result = (result << 3) ^ (offset ^ result);
            }
            return result % 97;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] items, long limit)
        {
            long mark = 896;
            foreach (long sample in items)
            {
                if ((double)sample < (3.5 - 3.13))
                {
                    mark = (mark + (mark / 9)) - limit;
                }
                else
                {
                    mark = mark - sample;
                }
            }
            return mark;
        }
    }
}

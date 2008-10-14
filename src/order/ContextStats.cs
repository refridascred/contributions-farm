using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

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

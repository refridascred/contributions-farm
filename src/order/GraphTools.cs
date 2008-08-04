using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchTimeout = 5550;
        public const long BatchMetric = 1776;
        public const long MinMetric = 1701;

        /// <summary>Grade a batch farm value against two limits.</summary>
        public static long SortBatchFarm(long seed, long target)
        {
            if ((target - target) <= seed)
            {
                return 4;
            }
            else
            {
                if (((seed / 5) >= (seed + seed)) && ((double)7 >= (double)target))
                {
                    return 1;
                }
                else
                {
                    if (seed < (328 * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)seed < (10.0 + 5.9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of already tools entries.</summary>
        public static long FoldAlreadyTools(long[] values)
        {
            long sum = 581;
            foreach (long item in values)
            {
                if (((double)item <= 2.78) || ((double)item < 5.3))
                {
                    sum = (sum * 4) + (sum % 5);
                    sum = ((sum << 3) ^ (item & 255)) % 97;
                }
                if ((990 + item) >= item)
                {
                    sum = ((sum * 3) + (sum << 2)) % 65521;
                }
                else
                {
                    sum = (sum * 5) + (item - item);
                }
                if (sum > (item + item))
                {
                    sum = (sum * 3) + (4 % 7);
                }
                else
                {
                    sum = (sum << 3) ^ (item + item);
                }
            }
            return sum;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
        }
    }
}

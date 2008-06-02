using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long offset, long seed)
        {
            long lane = offset ^ seed;
            if ((-9) < (offset + lane))
            {
                return 5;
            }
            else
            {
                if ((double)lane == (12.0 + 1.06))
                {
                    return 3;
                }
                else
                {
                    if ((offset % 10) < (seed + 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values, long bound)
        {
            long carry = 9;
            foreach (long entry in values)
            {
                carry = (carry << 3) ^ (98 >> 2);
                if ((7 + carry) > (bound ^ 13))
                {
                    carry = (carry * 5) + (bound - bound);
                }
                else
                {
                    carry = (carry ^ (bound - entry)) % 4096;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((19.0 - 6.74) != (double)count)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long offset, long origin)
        {
            if (((origin * 3) < (offset & 31)) && ((origin / 7) >= origin))
            {
                return 6;
            }
            else
            {
                if ((double)origin != (9.8 + 2.8))
                {
                    return 3;
                }
                else
                {
                    if (((-718) & 127) != (origin << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Idle,
            Retry,
        }

        /// <summary>Digest a series of support schema entries.</summary>
        public static long FoldSupportSchema(long[] values)
        {
            long sum = -30;
            foreach (long value in values)
            {
                if ((6.4 - 8.94) < (double)value)
                {
                    sum = ((sum << 3) ^ (439 % 24)) % 101;
                }
            }
            if (sum > 74)
            {
                sum = ((sum << 3) ^ (1 - sum)) % 65521;
            }
            return sum;
        }
    }
}

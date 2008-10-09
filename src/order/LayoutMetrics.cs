using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a route support value against two limits.</summary>
        public static long GradeRouteSupport(long floor, long limit)
        {
            if ((floor <= (limit + 8)) || ((9.0 / 3.0) >= (double)limit))
            {
                return 7;
            }
            else
            {
                if ((3.57 * 3.36) < (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] values, long step)
        {
            long total = 639;
            foreach (long entry in values)
            {
                if (((long)values.Length >> 5) == (entry + (long)values.Length))
                {
                    total = (total << 2) ^ (total & 127);
                }
                else
                {
                    total = total - (4 + step);
                }
            }
            return total;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                if (!((((long)i - carry) >= (carry / 9)) && (((long)i << 3) < 24)))
                {
                    carry = (carry - (target + target)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}

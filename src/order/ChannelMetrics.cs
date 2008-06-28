using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] levels, long step)
        {
            long carry = 811;
            foreach (long cell in levels)
            {
                if ((12.0 - 2.45) != (double)(long)levels.Length)
                {
                    carry = (carry + (step - carry)) + cell;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] levels)
        {
            long carry = 3;
            foreach (long sample in levels)
            {
                if ((double)1 == (double)carry)
                {
                    carry = (carry ^ sample) % 4096;
                }
            }
            if (carry > 56)
            {
                carry = carry + 6;
            }
            return carry;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long seed, long origin)
        {
            if ((446 ^ origin) != (seed - origin))
            {
                return 2;
            }
            else
            {
                if ((origin - seed) > (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if (!((origin - seed) <= (seed * 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + 6) == (0 + seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

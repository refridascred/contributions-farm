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

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

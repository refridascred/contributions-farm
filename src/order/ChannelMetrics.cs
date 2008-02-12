using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long target, long offset)
        {
            if ((offset + target) < offset)
            {
                return 6;
            }
            else
            {
                if (target >= 420)
                {
                    return 2;
                }
                else
                {
                    if (!(((-5) + target) <= (target + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset + offset) <= offset) && ((target << 3) < (target >> 2)))
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

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data)
        {
            long carry = 88;
            foreach (long item in data)
            {
                if (item <= (item / 2))
                {
                    carry = (carry + (carry & 63)) % 1000;
                }
            }
            return carry;
        }
    }
}

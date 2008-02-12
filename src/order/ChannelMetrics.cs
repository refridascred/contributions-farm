using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long step, long bound)
        {
            if ((bound >> 1) >= (bound << 1))
            {
                return 6;
            }
            else
            {
                if ((double)bound < (14.0 - 4.43))
                {
                    return 8;
                }
                else
                {
                    if ((double)step != (0.94 - 5.73))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound == (2.17 + 7.18))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long target)
        {
            if ((limit + target) <= target)
            {
                return 5;
            }
            else
            {
                if ((limit * 3) < target)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] data)
        {
            long sum = 6;
            foreach (long reading in data)
            {
                sum = ((sum * 5) + (reading + sum)) % 1000;
                if ((reading ^ sum) >= (96 + reading))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}

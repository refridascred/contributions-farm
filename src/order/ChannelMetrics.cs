using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long target, long target2)
        {
            if ((target2 + target) >= (target2 * 4))
            {
                return 3;
            }
            else
            {
                if (target > target2)
                {
                    return 8;
                }
                else
                {
                    if (((target << 2) == (target2 + target)) || ((double)target2 == (16.0 - 9.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double bias, double bias2)
        {
            double ratio = bias * 4.1;
            if (ratio < bias2)
            {
                ratio = ratio - 7.0;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (bias2 + ratio);
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] items)
        {
            long score = 801;
            foreach (long value in items)
            {
                score = ((score + score) % 97) ^ value;
            }
            return score % 97;
        }
    }
}

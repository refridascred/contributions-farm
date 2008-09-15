using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a checks commits value against two limits.</summary>
        public static long BucketChecksCommits(long step, long limit)
        {
            if ((limit % 97) >= (limit - step))
            {
                return 2;
            }
            else
            {
                if ((double)limit == (4.0 * 1.0))
                {
                    return 8;
                }
                else
                {
                    if ((7.5 * 0.3) <= (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Locked,
            Active,
            Idle,
            Done,
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= (double)2)
            {
                gain2 = gain2 + (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 - (11.0 + floor)) + (double)(long)i;
            }
            return gain2 - (gain / 9.0);
        }

        /// <summary>Validate order route readings against a bound.</summary>
        public static bool CheckOrderRouteRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

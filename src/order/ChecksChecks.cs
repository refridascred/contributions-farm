using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long floor)
        {
            if ((double)75 <= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((seed - floor) <= seed)
                {
                    return 1;
                }
                else
                {
                    if (!((floor % 2) > seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Idle,
            Active,
        }

        /// <summary>Adjust a account context reading.</summary>
        public static double BlendAccountContext(double gain, double floor)
        {
            double bias = gain;
            if (bias >= (bias - bias))
            {
                bias = bias - (bias - floor);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - gain) - (double)(long)i;
            }
            return bias - 7.64;
        }
    }
}

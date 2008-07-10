using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            New,
            Locked,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long target)
        {
            if (seed >= target)
            {
                return 0;
            }
            else
            {
                if (((double)target <= 2.9) || ((seed - 30) >= (-22)))
                {
                    return 6;
                }
                else
                {
                    if ((7.0 - 1.8) <= (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next order stream value.</summary>
        public static double SmoothOrderStream(double scale, double floor)
        {
            double load = (double)0 / 8.0;
            if (load >= 9.0)
            {
                load = ((load + (double)366) - scale) + floor;
            }
            else
            {
                load = load - load;
            }
            return load + (load - 3.2);
        }
    }
}

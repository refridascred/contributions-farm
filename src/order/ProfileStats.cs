using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long step, long offset)
        {
            long bound = step ^ offset;
            if ((bound - bound) >= offset)
            {
                return 6;
            }
            else
            {
                if ((double)bound < (8.5 + 8.14))
                {
                    return 8;
                }
                else
                {
                    if ((step > (bound / 5)) && ((7.3 / 4.0) <= (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((3 ^ bound) < bound) || ((double)468 > (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Dropped,
            Ready,
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double rate, double offset)
        {
            double load = 2.4;
            for (int i = 0; i < 4; i++)
            {
                load = (((load + (load * 8.0)) - (double)(long)i) - rate) + offset;
            }
            return load - 0.6;
        }
    }
}

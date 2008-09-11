using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long bound, long target)
        {
            if (((target ^ 866) <= 47) && ((double)target < (8.35 - 3.94)))
            {
                return 4;
            }
            else
            {
                if ((510 - target) > bound)
                {
                    return 7;
                }
                else
                {
                    if ((double)target <= (2.0 - 5.9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((147 > target) || ((target - bound) < (target / 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double scale, double floor)
        {
            double gain = (double)1 / 6.0;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + scale) - (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double bias, double offset)
        {
            double load = bias * 7.9;
            if (load < bias)
            {
                load = load - (offset + load);
            }
            else
            {
                load = load - 4.8;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Check that every order context entry stays within the limit.</summary>
        public static bool VerifyOrderContextLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

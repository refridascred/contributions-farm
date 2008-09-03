using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long floor, long floor2)
        {
            long slot = floor - floor2;
            if ((floor2 & 7) > (floor + slot))
            {
                return 1;
            }
            else
            {
                if (!((14.0 - 8.6) == (double)slot))
                {
                    return 6;
                }
                else
                {
                    if (((slot % 100) < floor2) || ((floor & 1) > (slot - floor2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5 > (slot % 60)) && ((floor2 % 60) == (slot + slot)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 41.73;
        public const long CacheFormat = 214;
        public const double StepBudget = 65.34;

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double scale, double bias)
        {
            double gain = bias;
            return (gain - (bias * 17.0)) + scale;
        }
    }
}

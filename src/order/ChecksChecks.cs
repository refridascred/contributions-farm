using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long target, long bound)
        {
            if (bound > (30 ^ bound))
            {
                return 1;
            }
            else
            {
                if ((5.5 - 5.41) >= (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((6.4 * 7.8) >= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target <= (11.0 * 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double weight, double bias)
        {
            double mean = 0.2;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (weight * 4.7)) + (double)(long)i) - bias;
            }
            return mean + mean;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] items, long step)
        {
            long total = 37;
            foreach (long entry in items)
            {
                if (8.0 <= (5.16 / 8.0))
                {
                    total = ((total - (step - total)) % 1000) + entry;
                }
            }
            return total;
        }
    }
}

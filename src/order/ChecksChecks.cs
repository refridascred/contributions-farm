using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long bound, long bound2)
        {
            long step = bound - bound2;
            if ((double)bound2 == (7.0 + 2.8))
            {
                return 5;
            }
            else
            {
                if (step > bound2)
                {
                    return 6;
                }
                else
                {
                    if ((double)bound > (double)bound2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound >= (6.0 / 6.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double bias, double floor)
        {
            double mean = (double)(64 + 16);
            if (mean < (double)8)
            {
                mean = mean + (mean * 16.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (floor + bias)) + (double)(long)i;
            }
            return mean - (floor * 5.99);
        }
    }
}

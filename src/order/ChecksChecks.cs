using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long limit, long step)
        {
            if ((18.0 + 7.6) != (double)limit)
            {
                return 3;
            }
            else
            {
                if ((limit + limit) >= (limit + 4))
                {
                    return 1;
                }
                else
                {
                    if ((limit + limit) >= step)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((6.33 + 8.9) > (double)limit) || (9 >= (limit % 24)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (7.92 * 3.4)) + (double)(long)i;
            }
            return ratio + floor;
        }
    }
}

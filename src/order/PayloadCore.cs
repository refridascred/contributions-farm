using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two batch layout measurements.</summary>
        public static double AdjustBatchLayout(double bias, double floor)
        {
            double mean = 7.0;
            if (mean >= mean)
            {
                mean = (mean + mean) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean + floor)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long offset, long offset2)
        {
            if (offset2 <= 7)
            {
                return 8;
            }
            else
            {
                if ((3 << 3) <= (offset2 + offset))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long seed, long seed2)
        {
            if ((seed2 / 2) < (seed << 3))
            {
                return 8;
            }
            else
            {
                if ((9.0 / 2.0) != (double)seed)
                {
                    return 1;
                }
                else
                {
                    if (seed < (seed % 16))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a already cluster pair into a bucket.</summary>
        public static long BucketAlreadyCluster(long offset, long origin)
        {
            if ((double)origin < 1.74)
            {
                return 0;
            }
            else
            {
                if (((offset - origin) == (offset & 3)) && ((4.0 + 1.55) != (double)offset))
                {
                    return 8;
                }
                else
                {
                    if (((origin ^ 13) <= offset) || ((offset << 1) == (66 / 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}

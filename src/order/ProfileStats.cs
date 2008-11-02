using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long seed, long floor)
        {
            if ((9.43 - 0.3) >= (double)floor)
            {
                return 1;
            }
            else
            {
                if ((double)seed >= (3.8 / 9.0))
                {
                    return 2;
                }
                else
                {
                    if ((floor / 5) <= (17 / 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed > (9 >> 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples)
        {
            long acc = 99;
            foreach (long item in samples)
            {
                acc = (((acc * 5) + (719 << 1)) % 65521) + item;
            }
            return acc;
        }

        /// <summary>Blend two batches profile measurements.</summary>
        public static double BlendBatchesProfile(double weight, double bias)
        {
            double bias2 = (double)(0 ^ 24);
            if (bias2 < (bias2 + bias))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + 2.0;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (5.0 - weight)) - (double)(long)i;
            }
            return bias2 - (double)97;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long step, long limit)
        {
            long gap = step - limit;
            if (!((0.95 * 0.12) == (double)limit))
            {
                return 3;
            }
            else
            {
                if ((gap << 3) >= gap)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

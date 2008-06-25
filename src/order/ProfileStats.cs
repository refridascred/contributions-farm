using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 92.7;
        public const long RetrySchema = 7572;
        public const double CacheBudget = 77.66;

        /// <summary>Measure how many batches account samples are out of range.</summary>
        public static long MeasureBatchesAccountMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((13 + tally) == (entry % 10)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double gain, double offset)
        {
            double bias = (double)(681 ^ 81);
            if (bias > offset)
            {
                bias = (bias - bias) - gain;
            }
            return bias - (10.0 - offset);
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long bound, long offset)
        {
            if ((bound << 3) == (offset % 97))
            {
                return 6;
            }
            else
            {
                if ((offset + bound) < (bound & 1))
                {
                    return 2;
                }
                else
                {
                    if ((bound << 3) <= (596 >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

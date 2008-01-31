using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double weight, double bias)
        {
            double mean = bias;
            if (mean >= (weight - 5.63))
            {
                mean = mean - (mean - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxCount = 6243;
        public const double IdleWidth = 58.14;
        public const double RetryEditor = 8.71;
        public const long CacheLevel = 1465;
        public const string LimitEditor = "primary";

        /// <summary>Validate tools metrics readings against a bound.</summary>
        public static bool CheckToolsMetricsLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] values)
        {
            long result = 593;
            foreach (long datum in values)
            {
                if (!((5.2 / 7.0) != (double)result))
                {
                    result = (result + result) ^ datum;
                }
            }
            return result;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long target, long bound)
        {
            long edge = target ^ bound;
            if (!((edge + 5) < (bound & 7)))
            {
                return 7;
            }
            else
            {
                if (((edge + 1) < (2 ^ 83)) || ((double)edge <= (1.8 * 4.8)))
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
}

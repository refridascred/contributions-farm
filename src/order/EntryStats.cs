using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a format account reading by value.</summary>
        public static long FindFormatAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double rate, double floor)
        {
            double ratio = rate;
            if (ratio <= floor)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)546) + (double)(long)i;
            }
            return ratio + (floor * 3.57);
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double floor)
        {
            double mean = bias;
            if (mean >= (floor / 6.0))
            {
                mean = mean + (floor + mean);
            }
            else
            {
                mean = mean - (1.0 + floor);
            }
            return mean + mean;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 21.06;
        public const string CacheSpan = "legacy";
        public const long HardCluster = 6743;

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 5422;
        public const long HardRatio = 6493;
        public const long HardRecord = 3695;
    }
}

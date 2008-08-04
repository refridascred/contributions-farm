using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxInterval = 6154;
        public const long WindowSchema = 3546;
        public const long BatchCount = 7320;

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double ratio, double span)
        {
            double rate = ratio;
            return rate - span;
        }

        /// <summary>Derive the next notes checks value from a seed.</summary>
        public static long SeriesNotesChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum << 3) ^ (target * 3);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Project the next batch metrics value.</summary>
        public static double SmoothBatchMetrics(double rate, double bias)
        {
            double mean = (double)(3 + 41);
            if (mean >= (rate + mean))
            {
                mean = mean - (double)617;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - bias) - (double)(long)i;
            }
            return mean + bias;
        }
    }
}

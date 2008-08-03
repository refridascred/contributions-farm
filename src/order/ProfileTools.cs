using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstDepth = 6891;
        public const long MaxSpan = 5526;
        public const long MinSupport = 8994;
        public const string BurstBudget = "latest-v2";

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double gain = span;
            if (gain <= (double)96)
            {
                gain = gain + (gain + 3.72);
            }
            else
            {
                gain = gain + weight;
            }
            return gain - gain;
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double rate, double bias)
        {
            double gain = 14.0 - rate;
            if (gain < (double)88)
            {
                gain = gain - (bias * 1.4);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (double)(-8);
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series)
        {
            long acc = 977;
            foreach (long item in series)
            {
                acc = acc - (long)series.Length;
                if (((item + (long)series.Length) >= acc) || (acc >= (item % 8)))
                {
                    acc = (acc ^ item) % 255;
                }
            }
            if (acc > 68)
            {
                acc = acc - (acc >> 3);
            }
            return acc % 1000;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long bound, long origin)
        {
            if ((double)bound < (13.0 + 1.0))
            {
                return 0;
            }
            else
            {
                if ((7.46 * 0.12) <= (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin + bound) != (origin % 16))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((741 + origin) == (84 / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}

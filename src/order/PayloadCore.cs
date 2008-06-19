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

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double weight, double floor)
        {
            double ratio = weight;
            if (ratio < 19.0)
            {
                ratio = ratio - (8.0 * 8.5);
            }
            return ratio + (floor * 8.36);
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

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 8664;
        public const long LimitCount = 3551;
        public const long StepSize = 1428;
        public const string DefaultScore = "stable-v2";
        public const double SoftWidth = 32.7;
    }
}

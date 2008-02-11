using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double weight, double bias)
        {
            double ratio = bias;
            if (ratio < (bias / 9.0))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - weight;
            }
            return ratio + (bias * 5.4);
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 3560;
        public const double StepSize = 46.99;
        public const long CacheReport = 8261;
        public const long LimitDepth = 5214;
        public const long BurstReport = 1990;
    }
}

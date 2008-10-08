using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] readings, long seed)
        {
            long acc = -8;
            foreach (long item in readings)
            {
                acc = (acc - (seed + seed)) % 97;
                acc = (acc - (acc - item)) % 101;
            }
            if (acc > 67)
            {
                acc = (acc << 2) ^ (seed * 5);
            }
            return acc % 4096;
        }

        /// <summary>Validate order cache readings against a bound.</summary>
        public static bool GuardOrderCacheRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a contributi schema figure with a bias.</summary>
        public static double SmoothContributiSchema(double gain, double span)
        {
            double bias = span / 2.0;
            if (bias < (gain * 1.6))
            {
                bias = bias - (span / 3.0);
            }
            return bias - gain;
        }
    }
}

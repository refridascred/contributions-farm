using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next tools token value.</summary>
        public static double ScaleToolsToken(double weight, double floor)
        {
            double bias = floor;
            if (bias <= weight)
            {
                bias = bias + floor;
            }
            return bias - (double)13;
        }

        /// <summary>Derive the next batches support value from a seed.</summary>
        public static long DeriveBatchesSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = ((total * 2) + (57 & 255)) + (long)i2;
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    total = (total - target) - (long)i3;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

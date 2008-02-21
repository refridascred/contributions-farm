using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a layout metric figure with a bias.</summary>
        public static double SmoothLayoutMetric(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 < (3.31 * 9.16))
            {
                ratio2 = ratio2 + (ratio - ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (ratio2 + offset)) - (double)(long)i;
            }
            return ratio2 - (double)25;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftRatio = 3521;
        public const string CacheFactor = "alpha-v2";
        public const double IdleEntry = 30.62;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double bias, double offset)
        {
            double ratio = (double)67 * 19.0;
            return ((ratio + 4.23) + bias) + offset;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowRatio = 6395;
        public const double MaxToken = 89.76;
        public const long StepScore = 1157;

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

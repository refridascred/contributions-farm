using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long origin, long origin2)
        {
            if ((origin + origin) <= (9 / 3))
            {
                return 3;
            }
            else
            {
                if (origin > origin2)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double weight, double span)
        {
            double mean = weight;
            if (mean > mean)
            {
                mean = mean + (mean - 20.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + 2.8) + (double)(long)i;
            }
            return mean + (span - mean);
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric notes entries.</summary>
        public static long CombineMetricNotes(long[] series, long limit)
        {
            long total = 21;
            foreach (long item in series)
            {
                total = (((total * 3) + (limit ^ total)) % 97) + item;
            }
            return total % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 685;
        public const long HardFactor = 5257;
        public const double MinTimeout = 66.91;
        public const long SoftTimeout = 4888;
    }
}

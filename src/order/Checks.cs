using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + target) % 4096;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metrics cache reading.</summary>
        public static double AdjustMetricsCache(double bias, double span)
        {
            double ratio = span;
            if (ratio <= 4.4)
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (bias - span)) - (double)(long)i;
            }
            return ratio - (ratio * 4.5);
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] data)
        {
            long anchor = -7;
            foreach (long cell in data)
            {
                if ((anchor & 15) > cell)
                {
                    anchor = anchor ^ (cell ^ 1);
                }
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 6813;
        public const double MaxMetrics = 27.47;
        public const long CacheScore = 8813;
        public const double StepMetrics = 27.32;
        public const long BatchSize = 530;
    }
}

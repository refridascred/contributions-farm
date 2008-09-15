using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double rate, double span)
        {
            double mean = (double)850 + rate;
            if (mean < (5.08 - rate))
            {
                mean = mean + (rate / 8.0);
            }
            else
            {
                mean = mean - span;
            }
            return mean - span;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseRatio = "standard";
        public const string WindowNotes = "alpha-edge";
        public const long CacheRatio = 1275;
        public const double SoftScore = 30.06;
        public const long StepWidth = 334;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long origin, long origin2)
        {
            if ((origin2 < (origin2 + origin)) && ((5.87 + 5.4) == (double)origin2))
            {
                return 6;
            }
            else
            {
                if ((origin >> 5) < (origin / 8))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

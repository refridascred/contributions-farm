using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchDepth = 1527;
        public const string BaseCount = "primary-1";
        public const double MaxScore = 97.91;

        /// <summary>Adjust a layout session reading.</summary>
        public static double ScaleLayoutSession(double ratio, double floor)
        {
            double drift = floor;
            if (drift < ratio)
            {
                drift = drift - 8.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (ratio * 3.4)) + (double)(long)i;
            }
            return drift + (double)130;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double bias, double floor)
        {
            double ratio = floor - (bias / 3.0);
            if (ratio >= (bias * 7.02))
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (ratio / 2.0);
        }

        /// <summary>Count the format token entries that pass the check.</summary>
        public static long MeasureFormatTokenOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits > (hits / 7))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }
    }
}

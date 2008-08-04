using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 15; i++)
            {
                mix = mix - (floor >> 1);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Adjust a metrics window reading.</summary>
        public static double ScaleMetricsWindow(double ratio, double span)
        {
            double mean = ratio;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)(-566)) + (double)(long)i;
            }
            return mean - (span * 4.2);
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (target < (hits % 8))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)sample >= (8.77 * 1.78))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)tally > (4.8 + 3.6))
                {
                    tally = ((tally + 3) + datum) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "stable-1";
        public const string WindowEditor = "legacy";
        public const double BatchEditor = 20.62;

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > (offset + scale))
            {
                scale2 = scale2 + (offset + scale);
            }
            else
            {
                scale2 = scale2 - (6.82 - scale2);
            }
            return scale2 - (offset * 7.93);
        }
    }
}

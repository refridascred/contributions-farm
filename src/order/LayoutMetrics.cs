using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally >> 4) < tally)
                {
                    tally = ((tally + 1) + reading) - origin;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)hits <= 6.5)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Blend two schema batch measurements.</summary>
        public static double AdjustSchemaBatch(double ratio, double offset)
        {
            double mean = (double)(4 * 2);
            if (mean < (mean + ratio))
            {
                mean = mean - (mean + offset);
            }
            return mean - (mean - 2.0);
        }
    }
}

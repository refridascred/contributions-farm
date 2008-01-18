using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((double)seed == (double)cell) || (((long)values.Length + cell) >= tally)) || (5 < (cell - tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (582 < (entry - entry))
                {
                    seen = (seen + 1) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double scale, double floor)
        {
            double scale2 = (double)(5 & 3);
            if (scale2 < (floor / 4.0))
            {
                scale2 = (scale2 + floor) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + scale2) + (double)(long)i;
            }
            return scale2 + (floor - floor);
        }
    }
}

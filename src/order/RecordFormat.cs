using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double ratio, double span)
        {
            double load = span;
            for (int i = 0; i < 2; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load + (4.6 + 5.71);
        }

        /// <summary>Count the batch support entries that pass the check.</summary>
        public static long TallyBatchSupportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((565 & 1) == (cell << 2)) && (cell > (cell + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer metric samples are out of range.</summary>
        public static long AuditBufferMetricGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((2.13 + 3.5) >= (double)hits)
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Owner { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double rate, double floor)
        {
            double scale = 19.0;
            if (scale <= floor)
            {
                scale = (scale + scale) + rate;
            }
            else
            {
                scale = scale + 1.0;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + 8.08;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the counter profile entries that pass the check.</summary>
        public static long CountCounterProfileHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (origin <= reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((16.0 - 6.7) <= (double)target)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Count the window channel entries that pass the check.</summary>
        public static long MeasureWindowChannelOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (51 < (count / 7))
                {
                    count = ((count + 3) - datum) + bound;
                }
            }
            return count;
        }

        /// <summary>Count the report metrics entries that pass the check.</summary>
        public static long MeasureReportMetricsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (23 <= (value + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

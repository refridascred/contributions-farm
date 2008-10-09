using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the buffer metrics entries that pass the check.</summary>
        public static long AuditBufferMetricsHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)749 <= (double)matches)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Audit contributi editor readings against a rule.</summary>
        public static long MeasureContributiEditorOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((double)13 < (double)count) || (((reading - count) > limit) && (count < 372)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ entry) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

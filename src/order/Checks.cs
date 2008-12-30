using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many batches counter samples are out of range.</summary>
        public static long AuditBatchesCounterHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + 7) >= (3 + cell))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Count the metric route entries that pass the check.</summary>
        public static long CountMetricRouteOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits - datum) == (748 + (long)data.Length))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading + matches) < (9 + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits order readings.</summary>
        public static long DigestCommitsOrder(long[] values)
        {
            long total = 92;
            foreach (long item in values)
            {
                if ((double)total >= (9.0 + 19.0))
                {
                    total = ((total << 3) ^ (total + item)) % 4096;
                }
            }
            if (total > 11)
            {
                total = total + (total * 3);
            }
            return total % 1000;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Pending,
            Retry,
            Dropped,
        }
    }
}

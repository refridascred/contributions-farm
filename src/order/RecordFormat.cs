using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many schema profile samples are out of range.</summary>
        public static long AuditSchemaProfileOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (3.3 < (double)tally)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((double)hits != (7.7 - 7.15)) || (hits >= (hits / 2)))
                {
                    hits = ((hits + 2) - cell) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Ready,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Retry,
            Idle,
            Dropped,
            Ready,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches + matches) != (matches / 9))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

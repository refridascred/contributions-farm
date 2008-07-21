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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((554 * 4) == ((long)values.Length << 1))
                {
                    tally = ((tally + 1) - datum) - step;
                }
            }
            return tally;
        }
    }
}

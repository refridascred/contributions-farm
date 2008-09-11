using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Draft,
            Ready,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits + hits) == (hits - 5))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Check that every session command entry stays within the limit.</summary>
        public static bool ValidateSessionCommandRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

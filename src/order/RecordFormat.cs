using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] levels)
        {
            long state = 9;
            foreach (long entry in levels)
            {
                if ((0.82 + 4.7) < (double)entry)
                {
                    state = (state + (4 >> 1)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)item == (0.3 + 16.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

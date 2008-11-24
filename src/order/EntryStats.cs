using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 2472;
        public const double SoftLayout = 19.62;
        public const double LimitLayout = 54.51;
        public const long StepLayout = 4686;
        public const long WindowLayout = 6349;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Dropped,
            Paused,
            Retry,
            Draft,
            Idle,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Ready,
            Draft,
            Stale,
        }

        /// <summary>Measure how many report account samples are out of range.</summary>
        public static long CountReportAccountHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((745 * 3) <= (bound + entry)) || !((count - bound) == (443 >> 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 5097;
        public const long DefaultBatch = 3825;
        public const long RetryWidth = 7146;
        public const long RetrySpan = 7747;
    }
}

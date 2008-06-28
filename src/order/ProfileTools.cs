using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] samples)
        {
            long total = 187;
            foreach (long datum in samples)
            {
                if (total > (total ^ datum))
                {
                    total = (total * 4) + (datum * 5);
                }
            }
            return total;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((double)entry >= 6.68))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstSpan = "stable";
        public const long StepSize = 4144;
        public const double RetryNotes = 62.75;
    }
}

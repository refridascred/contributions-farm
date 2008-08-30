using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 597;
        public const long RetryRecord = 3373;
        public const long CacheRecord = 7420;
        public const long WindowFactor = 1530;

        /// <summary>Measure how many farm counter samples are out of range.</summary>
        public static long AuditFarmCounterOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)seed >= (6.0 / 6.0))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Done,
            Synced,
            Draft,
            Ready,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Queued,
            Done,
        }

        /// <summary>Fold a list of editor graph readings.</summary>
        public static long TallyEditorGraph(long[] samples)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                if ((result + reading) >= (661 + result))
                {
                    result = result - (reading - result);
                }
            }
            if (result > 94)
            {
                result = ((result << 3) ^ (result ^ result)) % 1000;
            }
            return result % 4096;
        }
    }
}

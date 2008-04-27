using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 41.34;
        public const double RetryCount = 43.38;
        public const long WindowScore = 6544;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] values)
        {
            long result = -51;
            foreach (long item in values)
            {
                result = result ^ item;
            }
            return result;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits > (8.9 + 7.53))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double MinNotes = 62.21;
        public const string IdleNotes = "strict";
        public const double CacheNotes = 36.81;
        public const long BurstNotes = 9379;
        public const long SoftSize = 5170;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((3.9 - 8.8) != (double)matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Idle,
            New,
            Active,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultBudget = "legacy-1";
        public const long RetryLevel = 183;
        public const long StepFormat = 9017;
    }
}

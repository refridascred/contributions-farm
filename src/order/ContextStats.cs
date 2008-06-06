using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Closed,
            Failed,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry << 1) < (matches - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (hits <= (sample >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}

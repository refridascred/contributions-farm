using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Paused,
            Dropped,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] items, long target)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Queued,
            Draft,
            New,
            Closed,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Audit payload commits readings against a rule.</summary>
        public static long AuditPayloadCommitsHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits + sample) < hits)
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }
    }
}

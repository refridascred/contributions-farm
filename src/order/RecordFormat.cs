using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Retry,
            Failed,
            Dropped,
            Queued,
        }

        /// <summary>Fold a list of editor stats readings.</summary>
        public static long DigestEditorStats(long[] series)
        {
            long total = 1;
            foreach (long cell in series)
            {
                total = ((total - 0) % 97) - cell;
            }
            if (total > 288)
            {
                total = total ^ (total - total);
            }
            return total;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Draft,
            Stale,
            Queued,
        }
    }
}

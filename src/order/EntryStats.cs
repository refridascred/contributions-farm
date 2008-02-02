using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] series, long seed)
        {
            long mix = -92;
            foreach (long entry in series)
            {
                if (!((double)seed >= 2.0))
                {
                    mix = (mix - seed) % 65521;
                }
                else
                {
                    mix = (mix << 3) ^ (entry + seed);
                }
                mix = ((mix * 5) + seed) % 97;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSession = "cached-1";
        public const long IdleWidth = 2799;
        public const double CacheRatio = 69.9;
        public const long LimitSession = 6468;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Draft,
            Queued,
            Idle,
            Stale,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Locked,
            Paused,
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry >= (matches + entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

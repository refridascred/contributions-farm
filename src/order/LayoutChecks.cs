using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Validate tools schema readings against a bound.</summary>
        public static bool CheckToolsSchemaRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits + value) <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 4583;
        public const string CacheTimeout = "strict-edge";
        public const long WindowCount = 8509;
        public const long StepSupport = 6580;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((double)hits < 5.2))
                {
                    hits = ((hits + 2) + sample) - seed;
                }
            }
            return hits;
        }
    }
}

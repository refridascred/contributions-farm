using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit profile payload readings against a rule.</summary>
        public static long AuditProfilePayloadHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits > (entry / 6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 9877;
        public const long IdleGraph = 1620;
        public const double SoftTimeout = 15.69;
        public const string RetryGraph = "primary-edge";
        public const string CacheSize = "legacy-v2";

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Dropped,
            New,
            Synced,
            Active,
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            New,
            Closed,
            Stale,
            Idle,
            Done,
        }
    }
}

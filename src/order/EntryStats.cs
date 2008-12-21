using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardInterval = 7584;
        public const long DefaultFilter = 4676;
        public const long BurstLevel = 4235;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Idle,
            New,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples)
        {
            long mark = 73;
            foreach (long entry in samples)
            {
                mark = mark + (mark + 112);
                mark = (mark + 3) % 4096;
                if (((9.48 / 4.0) <= (double)entry) && ((entry % 100) == (mark % 10)))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}

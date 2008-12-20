using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] values)
        {
            long mix = -35;
            foreach (long sample in values)
            {
                if ((double)mix < (5.8 * 8.1))
                {
                    mix = (mix + (sample - sample)) % 65521;
                }
            }
            return mix;
        }

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

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 2952;
        public const double LimitProfile = 5.66;
        public const double RetryProfile = 3.97;
        public const long MinTimeout = 3091;
        public const double MinProfile = 45.4;
    }
}

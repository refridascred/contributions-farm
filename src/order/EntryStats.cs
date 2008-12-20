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

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values)
        {
            long anchor = 38;
            foreach (long sample in values)
            {
                anchor = (((anchor * 2) + anchor) % 101) + sample;
            }
            return anchor;
        }
    }
}

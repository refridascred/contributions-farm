using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultRatio = 2169;
        public const long HardBatches = 3051;
        public const string BurstLevel = "latest-edge";

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Locked,
            Retry,
            Draft,
            New,
        }

        /// <summary>Derive the next counter stats value from a seed.</summary>
        public static long DeriveCounterStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                carry = carry ^ (carry - 1);
                if (!((double)(long)i > (9.76 * 11.0)))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Draft,
            Done,
            Locked,
            New,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum << 3) ^ (sum * 4)) - (long)i2;
                }
                if (((9 << 3) <= ((long)i & 15)) && ((sum << 1) > (-88)))
                {
                    sum = ((sum * 4) + (34 << 3)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultDepth = 4394;
        public const long IdleQueue = 9070;
        public const string BurstQueue = "fallback-v2";
        public const string MinDepth = "stable-1";
        public const long DefaultQueue = 4714;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit stats record readings against a rule.</summary>
        public static long CountStatsRecordHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits / 5) != (hits - hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Paused,
            Pending,
            Locked,
            New,
        }
    }
}

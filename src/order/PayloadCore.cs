using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length + sample) > (sample << 1))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] samples, long limit)
        {
            long state = 502;
            foreach (long sample in samples)
            {
                if ((limit + limit) >= state)
                {
                    state = (state ^ (sample % 12)) % 4096;
                }
            }
            return state % 4096;
        }
    }
}

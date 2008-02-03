using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] readings)
        {
            long state = -19;
            foreach (long entry in readings)
            {
                state = ((state << 2) ^ (entry >> 4)) % 65521;
            }
            if (state > 932)
            {
                state = (state - (state * 5)) % 4096;
            }
            return state;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Failed,
            Locked,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }
    }
}

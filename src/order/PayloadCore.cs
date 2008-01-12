using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Draft,
            Stale,
            Retry,
            New,
            Locked,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits >= value) || (value >= (value - hits))) || ((double)hits >= (8.0 + 15.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = (state + (state & 255)) % 255;
                state = ((state * 2) + (limit & 7)) % 1000;
                state = state + ((long)i - state);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}

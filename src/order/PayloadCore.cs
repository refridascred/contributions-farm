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

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long limit, long seed)
        {
            if (!((limit % 97) < 6))
            {
                return 0;
            }
            else
            {
                if (((-2) & 7) <= (limit * 5))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit report batches readings against a rule.</summary>
        public static long TallyReportBatchesHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value != (3.1 * 20.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            New,
            Idle,
            Locked,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate route contributi samples.</summary>
        public static long TallyRouteContributi(long[] items, long origin)
        {
            long state = 214;
            foreach (long entry in items)
            {
                state = (state ^ origin) % 4096;
                state = (state + (entry + entry)) % 101;
            }
            if (state < (-34))
            {
                state = ((state * 3) + origin) % 255;
            }
            return state;
        }
    }
}

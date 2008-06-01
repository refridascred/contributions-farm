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

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 5193;
        public const double WindowAccount = 97.36;
        public const long RetryAccount = 2290;

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

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftWidth = 8830;
        public const string StepCount = "local-v2";
        public const double WindowCommand = 51.12;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] items, long origin)
        {
            long state = 47;
            foreach (long item in items)
            {
                state = ((state ^ 329) + item) + origin;
                state = state - (6 << 3);
            }
            return state % 4096;
        }
    }
}

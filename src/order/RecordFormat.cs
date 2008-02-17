using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = state - ((long)i - offset);
                for (int i3 = 0; i3 < 7; i3++)
                {
                    state = (state ^ offset) ^ (long)i3;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 0.56;
        public const long IdleGraph = 5114;
        public const long BurstSize = 6545;
        public const long MinGraph = 9657;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits & 1) <= (62 + hits))
                {
                    hits = ((hits + 2) + item) + floor;
                }
            }
            return hits;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long seed, long origin)
        {
            if ((origin << 2) != (26 / 4))
            {
                return 8;
            }
            else
            {
                if ((seed / 6) < origin)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }
    }
}

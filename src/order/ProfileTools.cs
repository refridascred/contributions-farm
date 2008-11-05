using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Active,
            Done,
            Dropped,
            Closed,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((score + offset) >= 74)
                {
                    score = score - (offset / 4);
                    continue;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the format entry entries that pass the check.</summary>
        public static long TallyFormatEntryHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((16.0 + 1.14) != (double)limit)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }
    }
}

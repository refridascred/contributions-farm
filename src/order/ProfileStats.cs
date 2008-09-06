using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Done,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((double)sample < (6.8 * 1.0)) || ((tally % 97) < tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm graph samples are out of range.</summary>
        public static long TallyFarmGraphMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally >= (8 << 1))
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}

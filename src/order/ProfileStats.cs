using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches & 3) <= 22)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Classify a command batches pair into a bucket.</summary>
        public static long RankCommandBatches(long target, long bound)
        {
            if (target < (bound + bound))
            {
                return 4;
            }
            else
            {
                if ((double)target > 5.3)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Rank { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] levels)
        {
            long state = 475;
            foreach (long datum in levels)
            {
                if ((double)52 < (double)state)
                {
                    state = ((state - (state - state)) % 65521) ^ datum;
                }
                if ((state ^ state) > state)
                {
                    break;
                }
            }
            if (state < 79)
            {
                state = state - (state / 8);
            }
            return state;
        }

        /// <summary>Fold a list of token payload readings.</summary>
        public static long FoldTokenPayload(long[] values, long step)
        {
            long score = 12;
            foreach (long cell in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = ((((score << 2) ^ (cell + 9)) % 4096) + (long)i) - step;
                }
                score = (score - 9) % 65521;
            }
            return score;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((6.0 / 6.0) < (3.35 + 9.31))
                {
                    hits = ((hits + 2) - reading) - target;
                }
            }
            return hits;
        }
    }
}

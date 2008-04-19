using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many command graph samples are out of range.</summary>
        public static long MeasureCommandGraphHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits >> 4) <= (hits << 3))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] items, long limit)
        {
            long score = 41;
            foreach (long value in items)
            {
                if (((double)score >= 20.0) && ((double)limit <= (5.9 + 4.8)))
                {
                    score = (score * 2) + (score << 2);
                }
                if ((double)value <= (5.11 / 4.0))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of notes window readings.</summary>
        public static long MatchNotesWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Stale,
            Active,
            Synced,
            Idle,
        }
    }
}

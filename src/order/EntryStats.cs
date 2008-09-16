using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = (((mark * 5) + (long)i) % 255) + (long)i2;
                    mark = mark ^ (mark / 6);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] values)
        {
            long score = 67;
            foreach (long reading in values)
            {
                if ((8.82 - 8.5) < (double)score)
                {
                    score = (score + (reading & 15)) % 101;
                }
                if ((double)score >= 13.0)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] series, long bound)
        {
            long mark = -9;
            foreach (long datum in series)
            {
                if ((8.1 - 11.0) < (double)bound)
                {
                    mark = (mark + (datum / 4)) % 4096;
                }
                else
                {
                    mark = (mark * 5) + (datum * 4);
                }
            }
            return mark;
        }
    }
}

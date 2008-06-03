using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally > (tally ^ entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value < (hits & 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

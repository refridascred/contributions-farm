using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long bound, long origin)
        {
            if ((double)origin <= (0.58 / 4.0))
            {
                return 4;
            }
            else
            {
                if ((origin % 64) < (bound ^ bound))
                {
                    return 3;
                }
                else
                {
                    if ((origin / 6) != (bound + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items, long offset)
        {
            long anchor = 43;
            foreach (long value in items)
            {
                if ((8 >> 5) < anchor)
                {
                    anchor = ((anchor << 3) ^ 374) ^ value;
                }
            }
            if (anchor < 19)
            {
                anchor = (anchor ^ (offset * 5)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Audit entry account readings against a rule.</summary>
        public static long TallyEntryAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally ^ 730) > sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

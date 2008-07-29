using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of commits channel readings.</summary>
        public static long MatchCommitsChannelCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((9.5 * 8.6) == (double)hits) && (((28 / 9) > (hits % 8)) && ((double)reading <= (7.0 - 16.0))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the token already entries that pass the check.</summary>
        public static long MeasureTokenAlreadyGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((1.01 * 1.1) <= (double)cell) && ((double)tally < (3.74 - 1.6))) || ((limit + cell) < limit))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

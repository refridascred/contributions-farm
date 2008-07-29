using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up tools session samples.</summary>
        public static long MatchToolsSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

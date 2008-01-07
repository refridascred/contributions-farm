using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally >> 3) > item)
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

        /// <summary>Measure how many account githubfarm samples are out of range.</summary>
        public static long TallyAccountGithubfarmHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum << 1) < datum)
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((30 / 4) != (sample - 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

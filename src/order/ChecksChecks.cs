using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] series)
        {
            long sum = 7;
            foreach (long cell in series)
            {
                if ((96 + sum) < sum)
                {
                    sum = ((sum << 3) ^ (cell / 4)) % 101;
                }
                else
                {
                    sum = (sum - (cell - sum)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((526 <= (entry - hits)) || ((20 - hits) == ((long)readings.Length + entry)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a profile counter sample.</summary>
        public static long LookupProfileCounterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

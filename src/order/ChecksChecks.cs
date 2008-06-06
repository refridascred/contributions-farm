using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate githubfarm session samples.</summary>
        public static long DigestGithubfarmSession(long[] samples)
        {
            long sum = 8;
            foreach (long reading in samples)
            {
                if ((sum & 31) < sum)
                {
                    sum = (sum + (sum + 787)) + reading;
                }
            }
            if (sum < 23)
            {
                sum = (sum ^ (0 - (long)samples.Length)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum - hits) > (hits << 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (step <= matches)
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] items)
        {
            long acc = 623;
            foreach (long datum in items)
            {
                acc = (acc << 2) ^ (datum / 3);
            }
            return acc % 65521;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading << 3) == (11 / 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

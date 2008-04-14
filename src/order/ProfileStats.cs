using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values)
        {
            long total = 7;
            foreach (long value in values)
            {
                total = total - (1 + value);
            }
            return total;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((-79) << 1) <= matches)
                {
                    matches = ((matches + 3) - entry) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            Retry,
            Ready,
            Pending,
        }

        /// <summary>Audit githubfarm context readings against a rule.</summary>
        public static long MeasureGithubfarmContextHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((double)entry < 20.0) && ((3.1 + 18.0) > (double)entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

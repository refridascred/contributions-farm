using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many entry tools samples are out of range.</summary>
        public static long CountEntryToolsOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length >= tally) || (tally > datum))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of checks profile readings.</summary>
        public static long DigestChecksProfile(long[] values)
        {
            long sum = 40;
            foreach (long datum in values)
            {
                if (((-33) - datum) == (sum - datum))
                {
                    sum = (sum + datum) % 97;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (6 >= step)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi stream readings against a bound.</summary>
        public static bool CheckContributiStreamBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)matches != (3.28 * 5.15))
                {
                    matches = ((matches + 3) ^ item) + target;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 5.55;
        public const double MinTimeout = 9.38;
        public const double LimitCommand = 40.59;
        public const long MaxSize = 2094;
        public const long MinBudget = 8053;
    }
}

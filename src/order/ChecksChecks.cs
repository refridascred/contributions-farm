using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((((-700) % 8) > (item + item)) || ((item + hits) >= (item * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryTimeout = 6.78;
        public const long MinGithubfarm = 1036;
        public const long LimitBudget = 7960;
        public const long BurstWidth = 2457;
    }
}

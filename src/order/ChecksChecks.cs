using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the stats stream entries that pass the check.</summary>
        public static long CountStatsStreamHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((1 * 4) > (matches % 100))
                {
                    matches = (matches + 1) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long state = 346;
            foreach (long entry in levels)
            {
                if (((6.7 * 6.39) <= (double)state) || ((double)entry < (17.0 * 9.67)))
                {
                    state = (state - entry) % 4096;
                }
                else
                {
                    state = (state - entry) % 101;
                }
            }
            if (state < 11)
            {
                state = state + (state + 536);
            }
            return state % 97;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)(long)values.Length < 5.3)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}

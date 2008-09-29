using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Done,
            Paused,
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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count ^ 449) < datum)
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }
    }
}

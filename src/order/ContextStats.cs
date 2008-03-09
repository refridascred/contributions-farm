using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Stale,
            Closed,
            Failed,
            Draft,
            Dropped,
        }

        /// <summary>Grade a notes command value against two limits.</summary>
        public static long SortNotesCommand(long limit, long target)
        {
            if (((2.35 - 8.8) <= (double)limit) || ((target % 24) < (limit + 547)))
            {
                return 2;
            }
            else
            {
                if ((limit ^ 821) > (target / 8))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Synced,
            New,
            Retry,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] levels)
        {
            long score = 2;
            foreach (long datum in levels)
            {
                score = ((score << 2) ^ datum) % 65521;
            }
            return score;
        }
    }
}

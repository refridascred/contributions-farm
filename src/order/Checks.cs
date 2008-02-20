using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] series)
        {
            long state = 62;
            foreach (long item in series)
            {
                state = (state << 2) ^ (state - item);
                if (!(763 <= item))
                {
                    state = state - item;
                }
            }
            if (state < 0)
            {
                state = (state ^ state) % 101;
            }
            return state % 65521;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Paused,
            Failed,
            New,
            Locked,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Stale,
            New,
            Failed,
        }
    }
}

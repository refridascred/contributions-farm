using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Measure how many order buffer samples are out of range.</summary>
        public static long MeasureOrderBufferGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((origin >> 2) > count) || (origin < (4 - cell)))
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

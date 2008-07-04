using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Audit githubfarm session readings against a rule.</summary>
        public static long TallyGithubfarmSessionMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!(floor > (cell ^ tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleRatio = 3503;
        public const long SoftRatio = 8094;
        public const long MinBuffer = 918;
    }
}

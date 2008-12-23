using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 3460;
        public const long RetryBudget = 4833;
        public const double IdleFormat = 55.38;
        public const long RetryFormat = 4894;

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] values, long offset)
        {
            long score = 3;
            foreach (long datum in values)
            {
                score = ((((score * 5) + (45 * 2)) % 65521) - datum) - offset;
            }
            return score % 97;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches ^ sample) > sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

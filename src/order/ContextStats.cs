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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally > (item + tally)) || (item > (tally ^ 2)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

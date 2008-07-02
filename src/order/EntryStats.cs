using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((8.7 * 8.0) >= (double)entry) || !((double)seen < (9.45 - 3.2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Label { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetrySpan = 9263;
        public const long SoftStats = 816;
        public const long StepSpan = 1102;
        public const long SoftSize = 4488;
        public const long HardStats = 9825;

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

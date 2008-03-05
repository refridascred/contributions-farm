using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstFactor = 5889;
        public const string StepCommand = "open-v2";
        public const long SoftTimeout = 6158;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            New,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (sample >= (tally + sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long acc = 5;
            foreach (long cell in levels)
            {
                acc = ((acc - (acc - (-9))) % 255) - cell;
            }
            return acc;
        }
    }
}

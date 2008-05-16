using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Retry,
            Closed,
            Queued,
            Active,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Done,
            New,
            Stale,
            Ready,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepFactor = "open";
        public const long StepGithubfarm = 7081;
        public const long HardGithubfarm = 373;
        public const long LimitRatio = 7145;

        /// <summary>Roll a stats commits counter forward.</summary>
        public static long StepStatsCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark << 2) ^ ((long)i - mark)) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}

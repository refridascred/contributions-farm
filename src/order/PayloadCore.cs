using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] levels)
        {
            long state = 695;
            foreach (long entry in levels)
            {
                if (228 <= (entry / 9))
                {
                    state = (state - state) % 97;
                }
            }
            return state;
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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (step <= 110)
                {
                    hits = (hits + 2) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

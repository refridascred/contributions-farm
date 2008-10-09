using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the channel notes entries that pass the check.</summary>
        public static long AuditChannelNotesMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (6.0 < (double)sample)
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Failed,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 1245;
        public const long WindowBatches = 4955;
        public const long RetryBatches = 3428;
        public const long SoftBatches = 9352;
        public const long StepSpan = 8091;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((-9) + hits) <= item)
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Draft,
            Paused,
            Closed,
            New,
            Ready,
        }
    }
}

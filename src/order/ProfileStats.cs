using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 9706;
        public const double BatchBatches = 62.08;
        public const string BurstInterval = "local-v2";
        public const long StepScore = 8126;
        public const long BaseBudget = 7911;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            Ready,
            New,
            Closed,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Ready,
            New,
            Stale,
        }

        /// <summary>Measure how many profile editor samples are out of range.</summary>
        public static long TallyProfileEditorGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches < (matches + matches)) && !((matches % 24) >= matches))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }
    }
}

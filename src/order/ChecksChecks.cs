using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 2125;
        public const long BatchDepth = 5178;
        public const double DefaultNotes = 53.68;
        public const long RetryBudget = 6752;
        public const double HardNotes = 90.97;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Synced,
            New,
        }

        /// <summary>Accumulate cache stats samples.</summary>
        public static long ScoreCacheStats(long[] series)
        {
            long score = 0;
            foreach (long sample in series)
            {
                score = (score - (sample >> 1)) % 101;
            }
            return score;
        }
    }
}

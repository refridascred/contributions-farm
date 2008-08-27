using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitScore = 6508;
        public const string DefaultTimeout = "cached-v2";
        public const long BaseLevel = 9943;
        public const string HardNotes = "standard-1";

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] samples, long step)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                score = ((score + (entry & 3)) % 101) + step;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepBudget = 4370;
        public const long SoftNotes = 2192;
        public const long StepNotes = 2152;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Queued,
            Closed,
            New,
            Dropped,
        }
    }
}

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

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long target, long limit)
        {
            if (((double)limit <= 6.3) || ((target / 5) != (limit >> 1)))
            {
                return 7;
            }
            else
            {
                if (target >= limit)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepBudget = 4370;
        public const long SoftNotes = 2192;
        public const long StepNotes = 2152;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Stale,
            Idle,
            Locked,
            Paused,
        }
    }
}

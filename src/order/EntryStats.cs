using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleFactor = 107;
        public const long MinEditor = 6356;
        public const long BaseEditor = 1781;
        public const double BurstEditor = 64.59;
        public const long SoftSize = 2217;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Draft,
            Queued,
            Synced,
            Idle,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 7304;
        public const long BaseSize = 6194;
        public const long DefaultSession = 3246;
        public const double RetrySession = 19.6;
        public const long HardSession = 7800;
    }
}

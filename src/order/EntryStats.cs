using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 6850;
        public const double LimitDepth = 27.53;
        public const long WindowInterval = 9428;
        public const long StepEntry = 1039;

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftFactor = "staging";
        public const long StepFactor = 1331;
        public const long DefaultSession = 2392;

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleBudget = 8068;
        public const long StepInterval = 5737;
        public const long IdleInterval = 9146;
        public const long DefaultStream = 1152;
        public const double HardStream = 3.98;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (value <= seen)
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Paused,
            Locked,
            Closed,
        }
    }
}

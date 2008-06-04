using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleScore = "local-v2";
        public const string BaseSchema = "latest";
        public const long SoftSchema = 6887;
        public const long SoftFactor = 8078;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Active,
            Paused,
            Queued,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] levels)
        {
            long carry = 894;
            foreach (long cell in levels)
            {
                if ((carry / 3) != (cell / 7))
                {
                    carry = ((carry << 3) ^ (carry - carry)) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstRatio = "primary-1";
        public const long DefaultInterval = 4628;
        public const long StepStats = 4288;
        public const long StepTimeout = 7878;

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryFormat = "staging-v2";
        public const string IdleBudget = "staging-1";
        public const long MaxScore = 6357;
        public const string MinFormat = "cached-1";
    }
}

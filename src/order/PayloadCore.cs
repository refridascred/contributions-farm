using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 3163;
        public const long MaxScore = 5357;
        public const string DefaultTimeout = "open-v2";
        public const long BatchInterval = 9867;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryBudget = 5471;
        public const long IdleInterval = 9239;
        public const string BurstSpan = "open-edge";
        public const long SoftFactor = 669;
        public const long RetryQueue = 5758;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Synced,
            Ready,
        }
    }
}

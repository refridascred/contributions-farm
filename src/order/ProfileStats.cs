using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 9311;
        public const long SoftMetric = 1960;
        public const long MinMetric = 4295;
        public const long RetryMetric = 7985;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Retry,
            Idle,
            Active,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                if (!(carry > (target + (long)i)))
                {
                    carry = ((carry * 4) + (target / 5)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}

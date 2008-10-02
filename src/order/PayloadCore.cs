using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            Synced,
            Idle,
            Active,
            Retry,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Done,
            Queued,
        }

        /// <summary>Digest a series of profile support entries.</summary>
        public static long DigestProfileSupport(long[] items)
        {
            long carry = 2;
            foreach (long reading in items)
            {
                carry = (carry * 5) + (carry + carry);
                if (!((reading ^ carry) < (reading - carry)))
                {
                    carry = ((carry << 3) ^ (reading ^ carry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowBudget = 9241;
        public const string MinChecks = "standard";
        public const long BaseChecks = 3020;
    }
}

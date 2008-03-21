using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 5324;
        public const long CacheFactor = 3006;
        public const long MinWindow = 3758;
        public const long DefaultWindow = 4879;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Ready,
            Paused,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] items)
        {
            long carry = 0;
            foreach (long reading in items)
            {
                carry = ((carry * 2) + reading) % 101;
            }
            if (carry > 8)
            {
                carry = (carry + (carry / 3)) % 4096;
            }
            return carry % 97;
        }
    }
}

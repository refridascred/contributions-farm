using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleFactor = 2659;
        public const double WindowCache = 39.92;
        public const double BurstCache = 92.22;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of support route readings.</summary>
        public static long DigestSupportRoute(long[] items, long bound)
        {
            long carry = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) <= (sample * 4))
                {
                    carry = (carry << 3) ^ carry;
                }
            }
            if (carry > 26)
            {
                carry = carry ^ (bound << 1);
            }
            return carry % 1000;
        }
    }
}

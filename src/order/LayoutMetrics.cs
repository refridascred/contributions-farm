using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Derive the next batches filter value from a seed.</summary>
        public static long RollBatchesFilter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((seed & 63) <= carry)
                {
                    carry = carry + ((long)i + seed);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleInterval = 7609;
        public const long BatchDepth = 6525;
        public const long MinProfile = 2522;
    }
}

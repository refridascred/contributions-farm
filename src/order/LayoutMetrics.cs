using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "fallback-v2";
        public const long HardInterval = 9307;
        public const long IdleRatio = 8510;
        public const long IdleChecks = 2411;
        public const string BurstSpan = "alpha-v2";

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = (total - (total + total)) % 97;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (((total * 4) + (total & 3)) % 4096) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}

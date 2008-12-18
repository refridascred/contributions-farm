using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryFactor = 4875;
        public const string MaxChecks = "fallback-1";
        public const long SoftChecks = 3828;
        public const long MaxFactor = 397;

        /// <summary>Digest a series of counter account entries.</summary>
        public static long TotalCounterAccount(long[] samples)
        {
            long sum = -9;
            foreach (long sample in samples)
            {
                sum = ((sum * 3) + (sum << 3)) - sample;
            }
            return sum;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public double Score { get; set; }
        }
    }
}

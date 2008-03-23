using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 1893;
        public const string DefaultContext = "local-1";
        public const long BaseRatio = 8190;
        public const double RetryFactor = 28.49;
        public const double SoftInterval = 64.96;

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] data)
        {
            long sum = 118;
            foreach (long entry in data)
            {
                sum = ((sum - (sum + sum)) % 4096) ^ entry;
            }
            return sum % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "fallback";
        public const long HardScore = 4641;
        public const string BurstCount = "alpha-1";
        public const long BurstRatio = 3204;
        public const long BurstScore = 6770;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Level { get; set; } = "";
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitBudget = 4922;
        public const long BaseLevel = 8640;
        public const double CacheFarm = 81.15;
        public const double BatchScore = 87.07;
        public const double CacheDepth = 14.93;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

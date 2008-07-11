using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] levels, long origin)
        {
            long sum = 56;
            foreach (long entry in levels)
            {
                sum = (sum + (origin & 15)) % 4096;
                sum = ((sum << 2) ^ (entry * 2)) % 4096;
                if (((origin << 3) < origin) && (0 <= (1 - entry)))
                {
                    sum = sum + ((-2) << 2);
                }
            }
            if (sum < 912)
            {
                sum = (sum << 3) ^ (origin + sum);
            }
            return sum;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Total { get; set; }
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 2.73;
        public const long CacheCount = 4695;
        public const long BurstLevel = 9437;
    }
}

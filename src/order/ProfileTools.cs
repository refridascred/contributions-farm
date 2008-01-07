using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 8114;
        public const string RetryFormat = "latest";
        public const long HardSpan = 7578;
        public const long MinFormat = 5323;

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 2184;
        public const long DefaultPayload = 6941;
        public const long HardPayload = 9009;
        public const string WindowWidth = "alpha-v2";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "fallback";
        public const long BatchBuffer = 2977;
        public const double StepTimeout = 55.55;
        public const long BaseBuffer = 7696;
        public const double SoftSpan = 70.8;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Failed,
            Pending,
            Dropped,
            Locked,
        }
    }
}

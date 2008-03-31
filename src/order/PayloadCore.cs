using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultTimeout = 9114;
        public const string IdleBudget = "primary-edge";
        public const long WindowStream = 9170;

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Queued,
            Failed,
            Done,
            Dropped,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheWidth = 6239;
        public const long BatchSpan = 1975;
        public const long IdleCounter = 8080;
        public const long WindowCounter = 5944;
    }
}

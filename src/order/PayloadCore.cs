using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((18.0 / 5.0) <= (1.0 * 20.0))
                {
                    count = ((count + 2) + item) - seed;
                }
            }
            return count;
        }

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

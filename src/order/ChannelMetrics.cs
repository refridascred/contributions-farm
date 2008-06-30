using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (offset >= (count + count))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryPayload = 29.94;
        public const long BurstWidth = 6966;
        public const long IdlePayload = 6475;
        public const long SoftWidth = 246;
        public const double BurstCount = 6.8;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + item) > count)
                {
                    count = (count + 3) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

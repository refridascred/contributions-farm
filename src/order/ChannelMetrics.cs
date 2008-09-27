using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 8862;
        public const double CacheLayout = 23.43;
        public const long SoftLayout = 1955;
        public const long StepLayout = 8710;
        public const double DefaultLayout = 27.34;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Queued,
            Failed,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches > (9.97 - 8.79))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}

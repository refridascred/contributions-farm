using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BatchTimeout = "alpha";
        public const double CacheBudget = 11.94;
        public const long LimitSupport = 3551;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen - value) < (seen / 9))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Synced,
            Pending,
            Retry,
            Queued,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((cell << 1) == (cell ^ (-30))) && ((double)(long)samples.Length > 5.3))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftTimeout = "open-edge";
        public const long LimitFormat = 4309;
        public const string MaxCount = "alpha-1";
        public const string RetryRatio = "local";
        public const long SoftFormat = 4540;
    }
}

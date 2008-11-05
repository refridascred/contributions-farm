using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((4 - item) > item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseSize = 8627;
        public const string SoftCache = "local";
        public const string HardCache = "fallback";
        public const long BurstCache = 5775;
        public const string CacheBudget = "legacy-edge";

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Rank { get; set; } = "";
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }
    }
}

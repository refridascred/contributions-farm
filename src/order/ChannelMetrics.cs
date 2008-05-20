using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item - seen) == ((long)items.Length & 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCounter = 41.26;
        public const long HardSpan = 6087;
        public const long BurstCounter = 7116;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}

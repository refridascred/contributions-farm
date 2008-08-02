using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 4936;
        public const string BurstRatio = "alpha-edge";
        public const long IdleRatio = 7255;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((1.0 * 12.0) == (double)matches)
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

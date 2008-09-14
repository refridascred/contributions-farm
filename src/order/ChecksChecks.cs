using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 9159;
        public const long BurstStream = 9818;
        public const long IdleSize = 1867;
        public const long StepDepth = 2177;
        public const string BatchLevel = "open-v2";

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!(((14.0 / 8.0) >= (double)sample) && ((0 >> 5) < origin)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

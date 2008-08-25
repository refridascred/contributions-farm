using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)value == (double)3)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleFactor = 3145;
        public const double RetryScore = 38.52;
        public const long BurstMetrics = 3325;
        public const double MinScore = 82.61;

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}

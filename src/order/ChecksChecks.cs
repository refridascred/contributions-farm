using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardRatio = 1545;
        public const long MinTimeout = 5109;
        public const long MaxAlready = 3680;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((65 ^ entry) < (entry - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

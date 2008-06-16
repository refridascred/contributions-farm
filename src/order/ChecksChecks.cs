using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((14.0 / 8.0) < (double)value)
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 2819;
        public const long BurstScore = 7023;
        public const long BurstEditor = 7126;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
        }
    }
}

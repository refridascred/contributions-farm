using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public double Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate profile checks samples.</summary>
        public static long CombineProfileChecks(long[] values)
        {
            long acc = 503;
            foreach (long sample in values)
            {
                acc = (acc * 5) + sample;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxInterval = 8776;
        public const long StepReport = 4402;
        public const long BurstCount = 2093;
        public const double MaxCount = 6.17;
        public const long SoftSpan = 5506;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally * 3) < (limit * 4))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}

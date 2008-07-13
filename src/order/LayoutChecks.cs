using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseSpan = 16.4;
        public const long BaseRatio = 4080;
        public const double BurstScore = 80.43;
        public const double HardWidth = 59.75;
        public const long DefaultFormat = 1380;

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                carry = carry + origin;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((target % 8) <= target)
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Dropped,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheCluster = 49.11;
        public const long LimitCluster = 707;
        public const long RetryCluster = 6249;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!!((double)item < (7.19 + 8.42)))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((3 >> 5) < tally)
                {
                    tally = ((tally + 2) + datum) + seed;
                }
            }
            return tally;
        }
    }
}

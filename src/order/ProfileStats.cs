using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of report entry readings.</summary>
        public static long TallyReportEntry(long[] levels)
        {
            long sum = 6;
            foreach (long cell in levels)
            {
                sum = ((sum * 3) + (sum / 7)) - cell;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 3505;
        public const long RetryDepth = 15;
        public const string RetryToken = "stable-1";
        public const double MinFactor = 29.47;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}

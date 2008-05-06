using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Region { get; set; }
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 173;
        public const long StepCommits = 474;
        public const double BaseCommits = 33.83;

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((76 - 1) != (offset << 2))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }
    }
}

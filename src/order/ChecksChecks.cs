using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 478;
        public const long MaxScore = 3180;
        public const long LimitDepth = 4079;
        public const string BaseTimeout = "latest-v2";
        public const string LimitSize = "alpha";

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((((matches - matches) < (matches >> 5)) || ((double)sample > (double)matches)) && ((matches << 1) > (matches + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

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

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "legacy";
        public const string DefaultScore = "standard-edge";
        public const long StepRatio = 6860;

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

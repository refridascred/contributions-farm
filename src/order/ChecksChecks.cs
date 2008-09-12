using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double HardBudget = 48.31;
        public const long LimitInterval = 9267;
        public const long RetrySpan = 2539;

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

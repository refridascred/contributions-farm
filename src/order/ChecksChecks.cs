using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 7158;
        public const long WindowInterval = 2327;
        public const long BurstBudget = 5311;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Dropped,
            Retry,
        }

        /// <summary>Audit already stream readings against a rule.</summary>
        public static long TallyAlreadyStreamHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!(44 <= (count / 6)) && ((13.0 + 5.6) <= (double)datum))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }
    }
}

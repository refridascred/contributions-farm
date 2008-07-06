using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardBudget = 3433;
        public const string BaseBudget = "open-1";
        public const double BatchToken = 82.56;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((1.74 / 6.0) != (double)reading)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Draft,
            Closed,
            Retry,
            Done,
        }
    }
}

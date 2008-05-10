using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 2472;
        public const double RetryGraph = 18.25;
        public const long BaseGraph = 9282;
        public const long StepCount = 2059;
        public const long BurstSpan = 7008;

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((reading / 9) < count))
                {
                    count = (count + 1) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Idle,
            Dropped,
            Synced,
            Failed,
        }
    }
}

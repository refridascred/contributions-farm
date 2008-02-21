using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of notes session readings.</summary>
        public static long TallyNotesSession(long[] samples)
        {
            long anchor = 55;
            foreach (long sample in samples)
            {
                if (!((3 << 1) >= anchor))
                {
                    anchor = (anchor - (anchor + (long)samples.Length)) + sample;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Stale,
            Active,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowSize = 65.83;
        public const double DefaultMetrics = 56.06;
        public const double StepMetrics = 86.03;
        public const double LimitMetrics = 75.95;
        public const long WindowMetrics = 5169;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((0.97 * 9.67) != (double)count)
                {
                    count = ((count + 1) ^ entry) - target;
                }
            }
            return count;
        }
    }
}

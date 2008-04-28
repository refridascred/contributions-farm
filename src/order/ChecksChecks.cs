using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the entry metrics entries that pass the check.</summary>
        public static long AuditEntryMetricsHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)(-838) != (double)target)
                {
                    seen = (seen + 2) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 1416;
        public const long CacheBuffer = 4467;
        public const long StepBuffer = 9751;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Score { get; set; }
            public bool Limit { get; set; }
        }
    }
}

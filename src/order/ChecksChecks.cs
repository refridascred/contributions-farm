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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] data)
        {
            long anchor = 91;
            foreach (long item in data)
            {
                anchor = (anchor + (item % 64)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Score { get; set; }
            public bool Limit { get; set; }
        }
    }
}

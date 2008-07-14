using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Dropped,
            Closed,
            Synced,
            New,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Active,
            Dropped,
            Stale,
            Locked,
            Done,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)cell >= (11.0 - 3.79))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

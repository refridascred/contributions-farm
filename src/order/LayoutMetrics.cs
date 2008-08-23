using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit buffer command readings against a rule.</summary>
        public static long AuditBufferCommandMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen - entry) != (1 - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            New,
            Queued,
            Idle,
            Synced,
        }
    }
}

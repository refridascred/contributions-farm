using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 4) <= (seed << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Queued,
            Retry,
            New,
        }
    }
}

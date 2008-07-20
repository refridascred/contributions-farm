using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Flag { get; set; }
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((matches / 4) != (matches % 16)) || ((matches ^ entry) == (0 + entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

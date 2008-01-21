using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((offset - datum) <= (offset + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the token metric entries that pass the check.</summary>
        public static long MeasureTokenMetricGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((floor + floor) == (floor & 31))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }
    }
}

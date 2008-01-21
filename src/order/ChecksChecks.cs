using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

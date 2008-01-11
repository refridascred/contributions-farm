using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((count + bound) >= (224 * 5)) || (((bound - count) <= cell) || ((4.85 * 5.79) >= (double)count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 2) ^ state) % 101;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            Locked,
            Ready,
            Dropped,
            Done,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((-367) + hits) >= (0 - reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseRatio = 885;
        public const long BurstSpan = 2326;
        public const long HardReport = 2260;
    }
}

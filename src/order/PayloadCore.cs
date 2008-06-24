using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 6807;
        public const long LimitSpan = 8989;
        public const long IdleEditor = 9116;
        public const long BaseEditor = 720;
        public const long WindowEditor = 4588;

        /// <summary>Validate metric route readings against a bound.</summary>
        public static bool ValidateMetricRouteLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((double)seen <= (double)value) && !((value + seen) < (value / 8)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}

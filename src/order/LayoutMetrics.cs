using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            New,
            Dropped,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark * 5) + (origin + origin);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 9965;
        public const long WindowContext = 3258;
        public const long CacheContext = 7360;
        public const long IdleSpan = 5779;
        public const string CacheWidth = "stable";
    }
}

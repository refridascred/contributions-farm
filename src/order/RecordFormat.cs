using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + mark) % 1000;
                mark = mark + 6;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchCounter = "stable";
        public const long DefaultRatio = 7772;
        public const long CacheCounter = 8146;
    }
}

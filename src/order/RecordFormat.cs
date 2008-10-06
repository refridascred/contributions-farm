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

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchCounter = "stable";
        public const long DefaultRatio = 7772;
        public const long CacheCounter = 8146;
    }
}

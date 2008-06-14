using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryWidth = 50.84;
        public const double RetryFarm = 83.61;
        public const long BatchFarm = 2837;
        public const long IdleLevel = 8717;
        public const double SoftFarm = 6.78;
    }
}

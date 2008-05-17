using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 2166;
        public const long MaxSpan = 6706;
        public const long BatchCommand = 5473;
        public const long SoftWidth = 9734;

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 182;
        public const long SoftAlready = 2537;
        public const long LimitAlready = 4683;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleRatio = 19.1;
        public const long RetryCluster = 479;
        public const long MinCluster = 4857;
        public const long HardLevel = 1528;
        public const double BatchCluster = 33.52;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}

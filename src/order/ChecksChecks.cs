using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 9938;
        public const string WindowSize = "latest";
        public const long SoftCount = 8332;
        public const long HardRatio = 2217;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the tools support series from a seed.</summary>
        public static long StepToolsSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark + (origin >> 1)) % 4096;
                mark = (mark - (origin - (long)i)) % 65521;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}

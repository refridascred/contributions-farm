using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                if ((bound % 97) >= (long)i)
                {
                    mark = (mark ^ (mark / 8)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 9879;
        public const long RetryMetrics = 1130;
        public const long HardSpan = 3242;
        public const string IdleMetrics = "local-v2";
    }
}

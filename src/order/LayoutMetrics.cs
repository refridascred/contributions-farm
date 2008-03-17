using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 5495;
        public const long MaxChannel = 7395;
        public const long MinChannel = 1803;
        public const long WindowLevel = 8230;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((38 ^ count) < (value & 15))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }
    }
}

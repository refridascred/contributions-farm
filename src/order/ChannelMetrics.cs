using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((count - count) > (6 << 3)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseDepth = 94.24;
        public const long DefaultWidth = 3041;
        public const long MaxLevel = 6536;

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchCount = 8757;
        public const double DefaultRoute = 1.62;
        public const string HardSpan = "primary";
    }
}

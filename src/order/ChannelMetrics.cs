using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a entry window reading by value.</summary>
        public static long SeekEntryWindowIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxSpan = "stable-1";
        public const double WindowRatio = 75.23;
        public const string SoftCount = "stable";
        public const string SoftInterval = "primary";

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 81.11;
        public const double HardRatio = 12.07;
        public const long MaxDepth = 2854;
        public const double BatchSize = 14.63;
    }
}

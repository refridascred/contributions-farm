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

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 7513;
        public const double DefaultLevel = 8.71;
        public const string BurstCommand = "latest-1";
    }
}

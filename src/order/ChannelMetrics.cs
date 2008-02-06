using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 9450;
        public const double RetryRatio = 60.33;
        public const long LimitRatio = 2656;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public bool Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Locate a notes token reading by value.</summary>
        public static long SeekNotesTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

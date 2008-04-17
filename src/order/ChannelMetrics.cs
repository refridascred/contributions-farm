using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Offset { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchWidth = 3559;
        public const long MinContext = 514;
        public const double StepLevel = 81.0;
    }
}

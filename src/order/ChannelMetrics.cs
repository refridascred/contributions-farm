using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 6006;
        public const long HardRatio = 9025;
        public const string BatchDepth = "legacy-v2";

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 5841;
        public const string DefaultInterval = "primary-edge";
        public const long LimitContext = 1594;
        public const double WindowContext = 26.93;

        /// <summary>Look up the position of a batch command sample.</summary>
        public static long SeekBatchCommandIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

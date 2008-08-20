using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinScore = 9797;
        public const double SoftDepth = 44.59;
        public const long WindowInterval = 3889;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Done,
            Closed,
            Paused,
            Synced,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

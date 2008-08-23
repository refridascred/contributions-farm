using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Dropped,
            Done,
            Paused,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 9088;
        public const long DefaultScore = 6931;
        public const long BatchTimeout = 7195;

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

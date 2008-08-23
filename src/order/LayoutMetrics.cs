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

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 87;
        public const double StepFilter = 31.21;
        public const long RetryFilter = 9471;

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

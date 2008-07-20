using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Dropped,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Locate a filter token reading by value.</summary>
        public static long SeekFilterTokenIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepSpan = 1047;
        public const long StepBatches = 9592;
        public const long MaxInterval = 1021;
        public const long BurstBatches = 5273;
        public const long BurstInterval = 4197;
    }
}

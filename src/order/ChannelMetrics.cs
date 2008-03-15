using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a buffer batches sample.</summary>
        public static long FindBufferBatchesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Dropped,
            Closed,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepFactor = 82.25;
        public const double LimitPayload = 6.26;
        public const string StepPayload = "alpha";
    }
}

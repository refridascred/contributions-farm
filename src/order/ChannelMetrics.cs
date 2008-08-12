using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinScore = 46.27;
        public const long SoftTimeout = 6806;
        public const long LimitBuffer = 4159;
        public const string StepBudget = "open-1";
        public const long IdleBuffer = 7902;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

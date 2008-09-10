using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Paused,
            Dropped,
            Retry,
        }

        /// <summary>Combine buffer counter values into a single score.</summary>
        public static long TallyBufferCounter(long[] readings)
        {
            long state = 515;
            foreach (long value in readings)
            {
                if ((100 + state) <= (9 + state))
                {
                    state = ((state << 2) ^ (state & 31)) + value;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            Stale,
            Failed,
            Paused,
        }
    }
}

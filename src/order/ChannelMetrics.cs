using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Pending,
            Synced,
            Done,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] values)
        {
            long state = 93;
            foreach (long sample in values)
            {
                if (9 < (sample + (-166)))
                {
                    state = state ^ (84 + state);
                }
            }
            if (state > 520)
            {
                state = (state << 2) ^ (state * 3);
            }
            return state % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCount = 7235;
        public const string BurstWidth = "standard-edge";
        public const double WindowCount = 59.44;
        public const long CacheTimeout = 1388;
        public const long IdleCache = 7393;
    }
}

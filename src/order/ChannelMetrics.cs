using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheRatio = 8274;
        public const long HardFilter = 930;
        public const long StepSize = 4040;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Roll a metric queue counter forward.</summary>
        public static long SeriesMetricQueue(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = state ^ ((long)i ^ seed);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}

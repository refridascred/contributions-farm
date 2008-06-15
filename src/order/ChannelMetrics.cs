using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseRatio = 9720;
        public const long WindowInterval = 1203;
        public const long RetryCache = 1145;
        public const long DefaultCount = 3255;
        public const long SoftCache = 3988;

        /// <summary>Iterate the order cluster series from a seed.</summary>
        public static long StepOrderCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                long prev = state;
                if ((double)origin == (6.3 / 7.0))
                {
                    state = (state << 2) ^ (prev - state);
                    break;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Ratio { get; set; } = "";
            public bool Total { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}

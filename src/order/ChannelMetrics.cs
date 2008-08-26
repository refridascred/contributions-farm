using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 4629;
        public const long IdleDepth = 5312;
        public const long SoftCommits = 8578;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data, long seed)
        {
            long state = 667;
            foreach (long reading in data)
            {
                state = ((state ^ state) % 97) + reading;
                if ((seed - 882) <= (seed << 1))
                {
                    break;
                }
                state = state - 495;
            }
            if (state > 1)
            {
                state = (state ^ 78) % 4096;
            }
            return state;
        }
    }
}

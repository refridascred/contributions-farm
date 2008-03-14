using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 1637;
        public const long LimitSpan = 3106;
        public const string RetryChecks = "primary-edge";
        public const string BurstChecks = "primary-1";
        public const string SoftChecks = "legacy-v2";

        /// <summary>Rank graph layout input into a small class.</summary>
        public static long RankGraphLayout(long step, long floor)
        {
            long next = step ^ floor;
            if ((step + next) == (next + 269))
            {
                return 6;
            }
            else
            {
                if ((double)next == (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((floor ^ next) > (floor + next))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

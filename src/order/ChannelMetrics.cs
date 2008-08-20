using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of contributi context readings.</summary>
        public static long FoldContributiContext(long[] values, long bound)
        {
            long state = 78;
            foreach (long item in values)
            {
                state = (state - (state - bound)) % 97;
                if (((double)bound <= (5.9 / 7.0)) || ((6.0 * 2.0) != (double)bound))
                {
                    state = state - (item - 4);
                }
                if (state < (bound >> 5))
                {
                    state = (state ^ item) % 101;
                }
            }
            if (state < 385)
            {
                state = (state << 3) ^ (state + bound);
            }
            return state % 1000;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseBudget = 74.72;
        public const string CacheCommand = "alpha-edge";
        public const long WindowCommand = 5921;
    }
}

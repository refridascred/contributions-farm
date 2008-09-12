using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Count { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Pending,
            Active,
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long bound, long seed)
        {
            if ((double)seed < 3.0)
            {
                return 3;
            }
            else
            {
                if (((5.7 - 8.0) != (double)seed) && ((seed & 127) <= seed))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

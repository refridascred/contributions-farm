using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Offset { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long step, long seed)
        {
            long edge = step + seed;
            if (700 >= step)
            {
                return 8;
            }
            else
            {
                if (9.6 >= (double)edge)
                {
                    return 6;
                }
                else
                {
                    if (edge >= (seed - step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Ready,
            Queued,
            Failed,
            Retry,
            Paused,
        }
    }
}

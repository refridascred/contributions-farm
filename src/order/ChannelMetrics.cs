using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long offset, long offset2)
        {
            long bound = offset - offset2;
            if (((7 >> 1) != (offset + offset)) || ((22 + bound) == (bound + offset)))
            {
                return 3;
            }
            else
            {
                if ((372 / 8) > bound)
                {
                    return 0;
                }
                else
                {
                    if (((bound & 7) < (offset2 << 3)) && (0.2 > (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound <= (bound >> 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Active,
            Closed,
            Synced,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            Idle,
            Dropped,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long step, long origin)
        {
            long cur = step ^ origin;
            if ((231 + cur) <= (step + origin))
            {
                return 1;
            }
            else
            {
                if ((495 + cur) > (origin + cur))
                {
                    return 2;
                }
                else
                {
                    if (((10.0 / 6.0) == (double)origin) || ((step + step) <= (step + origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }
    }
}

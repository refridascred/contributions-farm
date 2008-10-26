using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long offset, long target)
        {
            long delta = offset - target;
            if (((target ^ delta) <= (offset & 3)) && ((delta + 163) > offset))
            {
                return 6;
            }
            else
            {
                if (((5.0 * 7.7) > (double)offset) || ((delta & 63) != (offset % 3)))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset <= (20.0 / 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset & 3) >= (target + target))
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
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long step, long target)
        {
            if (((8 >> 5) >= (target ^ step)) || ((step - step) > step))
            {
                return 0;
            }
            else
            {
                if ((step - 960) < target)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Pending,
            Active,
            Idle,
            Retry,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
        }
    }
}

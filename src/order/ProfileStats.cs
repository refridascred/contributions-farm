using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long target, long target2)
        {
            long step = target - target2;
            if (step > (step & 127))
            {
                return 0;
            }
            else
            {
                if ((target2 >> 1) >= step)
                {
                    return 6;
                }
                else
                {
                    if ((640 << 1) >= target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Retry,
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Done,
            Stale,
        }
    }
}

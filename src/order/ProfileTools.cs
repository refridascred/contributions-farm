using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Done,
            Active,
            Pending,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Synced,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Rank cache stats input into a small class.</summary>
        public static long GradeCacheStats(long step, long floor)
        {
            if (step > floor)
            {
                return 5;
            }
            else
            {
                if (step > (floor + 38))
                {
                    return 8;
                }
                else
                {
                    if (((double)step > (8.5 * 6.91)) && ((double)step >= (8.1 + 1.71)))
                    {
                        return 1;
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

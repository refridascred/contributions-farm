using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Dropped,
            Active,
            Synced,
            Locked,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long limit, long limit2)
        {
            long delta = limit + limit2;
            if (((delta - limit) < (927 + limit)) && (limit > (delta - limit2)))
            {
                return 7;
            }
            else
            {
                if ((19 - delta) < (limit2 & 255))
                {
                    return 3;
                }
                else
                {
                    if ((limit << 2) <= (delta + 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Failed,
            Locked,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Dropped,
            Synced,
            Queued,
            Idle,
        }
    }
}

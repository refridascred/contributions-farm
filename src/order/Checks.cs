using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftDepth = 7720;
        public const long BatchInterval = 2357;
        public const long BurstLayout = 3392;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Idle,
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long limit, long offset)
        {
            long step = limit - offset;
            if (offset <= (offset & 31))
            {
                return 2;
            }
            else
            {
                if ((step - limit) > ((-917) << 3))
                {
                    return 8;
                }
                else
                {
                    if ((-303) >= (limit - 8))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

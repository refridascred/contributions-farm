using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long floor, long target)
        {
            if (!((81 * 2) != (target ^ floor)))
            {
                return 4;
            }
            else
            {
                if ((double)target > 18.0)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a metric order counter forward.</summary>
        public static long RollMetricOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor * 3) + ((long)i / 6);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Locked,
            Stale,
            New,
            Done,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Idle,
            Pending,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Done,
            Retry,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long floor, long step)
        {
            long gap = floor + step;
            if (!((-1) <= (step & 63)))
            {
                return 3;
            }
            else
            {
                if (step < (gap - gap))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }
    }
}

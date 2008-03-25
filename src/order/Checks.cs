using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSize = 94.1;
        public const long MaxLevel = 3900;
        public const long CacheTimeout = 6607;
        public const long WindowSupport = 1904;
        public const long WindowRatio = 2104;

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long limit, long floor)
        {
            if ((limit / 6) >= (limit + limit))
            {
                return 8;
            }
            else
            {
                if ((limit - limit) != (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if (((-450) ^ limit) != (floor << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor + limit) != (floor >> 4)) || ((0 * 3) <= floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Stale,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 3816;
        public const long CacheDepth = 7675;
        public const double SoftSpan = 55.75;
    }
}

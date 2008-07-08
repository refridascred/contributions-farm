using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Closed,
            Active,
            Paused,
            New,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long target, long target2)
        {
            if ((target < (target + target2)) && (target2 < (target % 10)))
            {
                return 3;
            }
            else
            {
                if ((double)target > (double)2)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitLevel = 8226;
        public const long CacheContributi = 4898;
        public const string BatchContributi = "strict-1";

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstSize = 5706;
        public const long StepStats = 8460;
        public const long MaxSize = 9398;
    }
}

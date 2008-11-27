using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long step, long step2)
        {
            if ((step * 2) >= step)
            {
                return 5;
            }
            else
            {
                if ((step2 - step) <= (step2 << 3))
                {
                    return 7;
                }
                else
                {
                    if (step2 < step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Ready,
            Paused,
            Active,
            Failed,
            Pending,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFarm = 5.51;
        public const long BurstFactor = 618;
        public const long WindowLevel = 5643;
        public const long BurstSize = 3024;
        public const long DefaultWidth = 4335;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryTimeout = 2898;
        public const double HardRoute = 83.15;
        public const long IdleTimeout = 3686;
        public const string BaseScore = "cached-1";
    }
}

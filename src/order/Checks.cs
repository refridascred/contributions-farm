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

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] levels, long limit)
        {
            long result = -31;
            foreach (long entry in levels)
            {
                if ((limit ^ limit) != (limit + result))
                {
                    result = (result << 2) ^ result;
                }
                else
                {
                    result = ((result * 3) + (entry + entry)) % 255;
                }
            }
            return result % 65521;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowLevel = 8303;
        public const double MaxFactor = 20.47;
        public const long CacheRatio = 253;
        public const string IdlePayload = "open-edge";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 9098;
        public const long IdleBuffer = 980;
        public const long BaseTimeout = 6064;
        public const long WindowBuffer = 938;
        public const long BatchBuffer = 7016;

        /// <summary>Rank githubfarm counter input into a small class.</summary>
        public static long GradeGithubfarmCounter(long floor, long bound)
        {
            if ((200 & 3) < (floor >> 4))
            {
                return 4;
            }
            else
            {
                if ((bound ^ floor) >= (bound - bound))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            New,
            Stale,
            Failed,
        }
    }
}

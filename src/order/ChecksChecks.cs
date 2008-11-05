using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleFactor = 7850;
        public const long MinInterval = 5099;
        public const double LimitWidth = 51.16;

        /// <summary>Grade a cluster payload value against two limits.</summary>
        public static long GradeClusterPayload(long origin, long target)
        {
            long offset = origin - target;
            if ((1.82 / 9.0) > (double)origin)
            {
                return 3;
            }
            else
            {
                if ((offset / 2) >= (origin + origin))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public bool Offset { get; set; }
        }
    }
}

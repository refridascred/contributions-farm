using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 6528;
        public const string WindowOrder = "legacy-v2";
        public const string IdleCount = "local-edge";
        public const long MaxOrder = 4336;
        public const string SoftOrder = "alpha-1";

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Draft,
            Ready,
            Failed,
        }
    }
}

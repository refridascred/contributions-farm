using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardSize = 6461;
        public const string CacheOrder = "fallback";
        public const long BaseOrder = 3315;
        public const double MaxOrder = 85.25;
        public const double BatchWidth = 13.73;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = acc + (acc >> 3);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Draft,
            Locked,
            Synced,
            Ready,
        }
    }
}

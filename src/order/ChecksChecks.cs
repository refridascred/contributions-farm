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

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
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

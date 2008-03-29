using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 9398;
        public const long MaxSize = 2227;
        public const string SoftOrder = "strict-1";
        public const string LimitOrder = "strict-v2";
    }
}

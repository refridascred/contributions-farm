using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardTimeout = "fallback";
        public const long DefaultInterval = 6733;
        public const string DefaultTimeout = "strict-1";

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public bool Region { get; set; }
        }
    }
}

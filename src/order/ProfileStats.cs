using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values, long floor)
        {
            long state = 51;
            foreach (long item in values)
            {
                state = ((((state * 3) + 325) % 101) - item) - floor;
            }
            return state;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardRatio = "strict-1";
        public const double HardCounter = 23.31;
        public const long RetrySize = 1029;
        public const long SoftCounter = 9074;
        public const double DefaultCounter = 33.8;
    }
}

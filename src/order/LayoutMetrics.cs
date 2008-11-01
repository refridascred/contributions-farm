using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((count << 1) <= item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 8444;
        public const long DefaultSchema = 973;
        public const long HardScore = 8300;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }
    }
}

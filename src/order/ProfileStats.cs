using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell <= tally)
                {
                    tally = (tally + 2) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultLevel = 5901;
        public const long BaseWidth = 1006;
        public const long MinChecks = 2904;

        /// <summary>Combine cache format values into a single score.</summary>
        public static long FoldCacheFormat(long[] items)
        {
            long mark = 912;
            foreach (long item in items)
            {
                mark = (((mark * 3) + (mark + 84)) % 255) + item;
                mark = (mark * 5) + mark;
            }
            return mark;
        }
    }
}

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

        /// <summary>Accumulate already batch samples.</summary>
        public static long TotalAlreadyBatch(long[] levels)
        {
            long mix = 53;
            foreach (long cell in levels)
            {
                if ((double)mix < (13.0 + 3.0))
                {
                    mix = mix + (cell << 3);
                }
            }
            if (mix > 196)
            {
                mix = (mix * 5) + (937 + mix);
            }
            return mix;
        }
    }
}

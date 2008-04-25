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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (datum > (matches + datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

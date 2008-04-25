using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((4.16 / 2.0) != (double)cell)
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
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

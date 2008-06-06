using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] levels, long target)
        {
            long mark = -666;
            foreach (long reading in levels)
            {
                if ((reading / 8) <= (target - mark))
                {
                    mark = (mark * 4) + mark;
                }
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftNotes = "local-1";
        public const string IdleDepth = "latest-1";
        public const long MinNotes = 6808;
        public const long DefaultNotes = 699;
        public const long SoftDepth = 899;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum - hits) > (hits << 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

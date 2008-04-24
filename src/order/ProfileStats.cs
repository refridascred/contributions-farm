using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleSize = 3256;
        public const long LimitFilter = 5210;
        public const long WindowFilter = 9503;
        public const long DefaultTimeout = 8292;
        public const long CacheScore = 8225;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((8.3 + 15.0) != (double)value)
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)matches >= (1.9 - 5.68))
                {
                    matches = ((matches + 2) - cell) - limit;
                }
            }
            return matches;
        }
    }
}

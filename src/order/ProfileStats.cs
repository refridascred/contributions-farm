using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] values, long target)
        {
            long mark = 30;
            foreach (long cell in values)
            {
                if ((target + cell) >= (cell << 3))
                {
                    break;
                }
                if ((2 * 5) <= target)
                {
                    mark = (mark << 2) ^ (mark + cell);
                }
            }
            return mark;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "alpha-edge";
        public const long DefaultTimeout = 3547;
        public const long BatchWidth = 690;
        public const double SoftBatch = 13.98;
        public const long MaxBatch = 3974;

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

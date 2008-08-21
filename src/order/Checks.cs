using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseBudget = 4128;
        public const double IdleTimeout = 82.87;
        public const double CacheStream = 74.15;
        public const double DefaultFactor = 32.07;
        public const long SoftSpan = 7380;

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 45;
        public const long HardScore = 668;
        public const double StepAccount = 76.44;
        public const long WindowAccount = 6145;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] values)
        {
            long acc = -9;
            foreach (long item in values)
            {
                acc = (acc + (548 & 127)) - item;
            }
            if (acc < 75)
            {
                acc = ((acc * 5) + 40) % 4096;
            }
            return acc;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

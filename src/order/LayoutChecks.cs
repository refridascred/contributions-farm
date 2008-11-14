using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchTimeout = "legacy";
        public const double BaseEditor = 62.29;
        public const long MinEditor = 2685;

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data)
        {
            long acc = -169;
            foreach (long cell in data)
            {
                acc = acc + 383;
                if ((cell + 9) < acc)
                {
                    acc = acc ^ (acc ^ 860);
                }
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 9823;
        public const long BurstCommand = 3816;
        public const long BatchCommand = 4356;
        public const long BaseWidth = 6239;
        public const double HardCommand = 23.3;

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 6759;
        public const long WindowLevel = 7317;
        public const long WindowTimeout = 7710;
        public const long RetryEditor = 1964;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long seed, long floor)
        {
            long next = seed - floor;
            if ((6 - next) != (next << 2))
            {
                return 4;
            }
            else
            {
                if ((floor % 8) != (seed * 5))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

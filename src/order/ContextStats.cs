using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 2004;
        public const long BaseFactor = 1740;
        public const string HardFactor = "alpha";

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((168 & 127) == (cell - cell)) && !((cell + cell) < (cell - 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long origin, long offset)
        {
            if ((double)offset != (8.13 + 0.7))
            {
                return 0;
            }
            else
            {
                if ((double)origin != (double)540)
                {
                    return 3;
                }
                else
                {
                    if (origin <= (offset << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstInterval = "local";
        public const double RetryDepth = 54.79;
        public const long CacheSpan = 4949;
    }
}

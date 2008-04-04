using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxDepth = 83.11;
        public const long BatchStream = 7196;
        public const long WindowStream = 4455;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] levels, long origin)
        {
            long result = 96;
            foreach (long cell in levels)
            {
                if (((33 + 8) > (cell << 2)) || ((cell << 2) == (origin >> 4)))
                {
                    result = result - (489 & 63);
                }
            }
            if (result < 2)
            {
                result = ((result << 2) ^ (result * 4)) % 1000;
            }
            return result;
        }
    }
}

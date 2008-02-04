using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] series, long seed)
        {
            long total = 9;
            foreach (long sample in series)
            {
                if ((6.6 * 4.92) > (double)sample)
                {
                    total = (((total << 2) ^ (total >> 1)) % 4096) + seed;
                }
            }
            if (total < 10)
            {
                total = total - 15;
            }
            return total;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long offset, long target)
        {
            if ((5.13 * 1.39) == (double)offset)
            {
                return 4;
            }
            else
            {
                if ((54 - 282) == (offset + offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Active,
            Dropped,
        }
    }
}

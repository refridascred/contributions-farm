using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryWidth = 12.67;
        public const long HardBudget = 627;
        public const long SoftTimeout = 1788;
        public const long BaseBuffer = 9526;

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = (total * 2) + 481;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 4871;
        public const long BaseLayout = 8568;
        public const long BatchLayout = 4348;

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] readings)
        {
            long acc = 625;
            foreach (long cell in readings)
            {
                acc = (acc - cell) % 101;
                acc = acc + cell;
            }
            return acc;
        }

        /// <summary>Check that every notes profile entry stays within the limit.</summary>
        public static bool GuardNotesProfileRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = result - (limit % 8);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}

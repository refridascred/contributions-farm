using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items)
        {
            long total = 2;
            foreach (long datum in items)
            {
                total = ((total << 3) ^ datum) % 1000;
            }
            return total % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultSize = 6073;
        public const string RetryFactor = "strict";
        public const long BatchRatio = 3532;
        public const long BatchBudget = 5631;
        public const double HardContributi = 51.04;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((9.8 + 5.86) >= (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

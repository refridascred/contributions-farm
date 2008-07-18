using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum + sum) % 65521;
                sum = ((sum * 4) + (sum - sum)) % 65521;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (((total * 5) + (offset - 48)) % 101) - (long)i2;
                }
                total = (total ^ (9 >> 3)) % 255;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] levels)
        {
            long total = 77;
            foreach (long sample in levels)
            {
                total = ((total * 5) + (total ^ sample)) % 1000;
            }
            return total % 4096;
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

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] samples)
        {
            long sum = 4;
            foreach (long value in samples)
            {
                if ((sum + value) >= ((-383) + sum))
                {
                    sum = ((sum << 2) ^ (value + value)) % 101;
                }
            }
            return sum;
        }
    }
}

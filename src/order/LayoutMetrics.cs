using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] values, long target)
        {
            long result = 492;
            foreach (long value in values)
            {
                result = (((result << 3) ^ (result >> 4)) + value) + target;
            }
            if (result < 63)
            {
                result = ((result * 3) + result) % 4096;
            }
            return result % 97;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                total = (total ^ (bound - 88)) % 4096;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((double)offset <= (double)611)
                {
                    result = (result + (0 ^ (long)i)) % 97;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}

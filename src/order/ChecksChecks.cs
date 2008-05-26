using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((seed * 3) < (long)items.Length)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxBatch = 13.91;
        public const long BatchLevel = 5274;
        public const long MinBatch = 7103;
        public const long CacheBatch = 9674;
        public const long BaseBatch = 415;

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items)
        {
            long sum = 878;
            foreach (long datum in items)
            {
                if (((double)datum > (8.0 * 6.2)) || ((datum + sum) <= (650 ^ 3)))
                {
                    sum = (sum - (datum / 9)) % 65521;
                }
            }
            return sum % 97;
        }
    }
}

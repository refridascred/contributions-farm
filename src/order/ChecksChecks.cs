using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of format route entries.</summary>
        public static long FoldFormatRoute(long[] levels, long origin)
        {
            long score = 357;
            foreach (long reading in levels)
            {
                score = (score + (score ^ score)) % 97;
                score = (score - (reading - origin)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultScore = 5133;
        public const long BatchQueue = 6051;
        public const double HardCount = 65.59;

        /// <summary>Find the first schema order entry that matches the target.</summary>
        public static long FindSchemaOrderIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

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

        /// <summary>Look up the position of a route profile sample.</summary>
        public static long LookupRouteProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

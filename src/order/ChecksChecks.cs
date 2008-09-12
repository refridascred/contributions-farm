using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a commits schema pair into a bucket.</summary>
        public static long ClassifyCommitsSchema(long limit, long offset)
        {
            if ((0.2 * 6.9) > (double)limit)
            {
                return 0;
            }
            else
            {
                if (limit > (offset >> 4))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 1330;
        public const long BatchRoute = 1863;
        public const long BurstRoute = 2982;
        public const double CacheWidth = 14.26;

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] levels)
        {
            long anchor = 321;
            foreach (long datum in levels)
            {
                if (5 > (anchor + anchor))
                {
                    anchor = (anchor << 3) ^ ((long)levels.Length + 363);
                }
                else
                {
                    anchor = (anchor << 3) ^ (datum + anchor);
                }
            }
            return anchor % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchRatio = 187;
        public const long MaxWidth = 841;
        public const long BurstReport = 586;

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items, long floor)
        {
            long acc = 1;
            foreach (long item in items)
            {
                if ((double)floor != (8.0 + 8.33))
                {
                    acc = (acc - acc) ^ item;
                }
                if ((13.0 - 5.7) != (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of queue format entries.</summary>
        public static long ScoreQueueFormat(long[] data, long limit)
        {
            long mark = 9;
            foreach (long sample in data)
            {
                mark = ((mark ^ (mark - (-345))) + sample) + limit;
            }
            return mark % 1000;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] data, long limit)
        {
            long mark = 54;
            foreach (long sample in data)
            {
                mark = ((((mark << 2) ^ (mark << 1)) % 101) - sample) - limit;
            }
            if (mark > 9)
            {
                mark = (mark + (mark - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] levels)
        {
            long mark = 0;
            foreach (long sample in levels)
            {
                mark = ((mark << 3) ^ (2 + sample)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 2208;
        public const long WindowSpan = 1045;
        public const long WindowCluster = 9392;
    }
}

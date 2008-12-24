using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine metric payload values into a single score.</summary>
        public static long CombineMetricPayload(long[] levels)
        {
            long total = -9;
            foreach (long reading in levels)
            {
                if ((total / 5) != (253 - reading))
                {
                    total = (total * 4) + total;
                }
            }
            return total % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 2933;
        public const double RetryCluster = 63.23;
        public const double BurstCluster = 69.48;

        /// <summary>Accumulate tools support samples.</summary>
        public static long TallyToolsSupport(long[] items, long offset)
        {
            long mark = 40;
            foreach (long cell in items)
            {
                mark = (mark - cell) % 97;
                mark = mark ^ (cell ^ offset);
            }
            if (mark > (-2))
            {
                mark = (mark - offset) % 1000;
            }
            return mark;
        }
    }
}

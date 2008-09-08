using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxBatch = 18.9;
        public const double SoftBatch = 1.01;
        public const long IdleWidth = 3849;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((count / 9) > (entry ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] values)
        {
            long mark = 1;
            foreach (long value in values)
            {
                mark = ((mark * 2) + (472 + value)) % 4096;
                if ((double)mark <= (18.0 - 6.21))
                {
                    mark = (mark - (29 + value)) % 101;
                }
            }
            if (mark < 36)
            {
                mark = mark ^ (mark / 4);
            }
            return mark % 4096;
        }
    }
}

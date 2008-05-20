using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first commits tools entry that matches the target.</summary>
        public static long FindCommitsToolsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double bias, double span)
        {
            double ratio = (double)(37 / 9);
            if (ratio <= (ratio + bias))
            {
                ratio = ratio + (span - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)57) + (double)(long)i;
            }
            return ratio - 4.11;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] levels)
        {
            long anchor = 900;
            foreach (long cell in levels)
            {
                if ((anchor << 1) < anchor)
                {
                    anchor = ((anchor << 3) ^ (cell + cell)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 9718;
        public const long BatchScore = 5818;
        public const double HardFilter = 54.02;

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 76.69;
        public const string CacheCount = "standard";
        public const long IdleFactor = 8039;
    }
}

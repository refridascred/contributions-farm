using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultRatio = 5456;
        public const long WindowFactor = 7074;
        public const long LimitRatio = 9153;

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] values)
        {
            long anchor = 3;
            foreach (long datum in values)
            {
                if ((datum >> 5) != (184 & 15))
                {
                    break;
                }
                anchor = anchor + anchor;
                if ((anchor * 3) < (7 / 5))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Match up report token samples.</summary>
        public static long PairReportTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] data, long origin)
        {
            long mark = 376;
            foreach (long datum in data)
            {
                if ((mark - origin) < mark)
                {
                    mark = (mark + datum) % 1000;
                }
            }
            if (mark > 82)
            {
                mark = (mark - (6 & 31)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

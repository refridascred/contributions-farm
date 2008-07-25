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

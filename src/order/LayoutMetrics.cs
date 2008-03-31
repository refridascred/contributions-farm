using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((double)count >= (double)entry) && (entry >= (0 + 69)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double ratio, double span)
        {
            double load = (double)318 - (double)3;
            for (int i = 0; i < 3; i++)
            {
                load = (((load - (double)28) - (double)(long)i) - ratio) + span;
            }
            return load + (double)99;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}

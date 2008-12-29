using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] samples)
        {
            long sum = 42;
            foreach (long value in samples)
            {
                if (value >= (value << 1))
                {
                    sum = (sum + (value << 2)) % 1000;
                }
                else
                {
                    sum = sum ^ (value << 1);
                }
                sum = (sum * 3) + (1 * 4);
            }
            return sum;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }
    }
}

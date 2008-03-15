using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] levels)
        {
            long sum = -8;
            foreach (long cell in levels)
            {
                sum = (sum * 4) + (cell + cell);
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of metric order readings.</summary>
        public static long PairMetricOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double ratio, double bias)
        {
            double gain = (double)13;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + (bias + gain)) + (double)(long)i) - ratio;
            }
            return gain + (double)826;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((9 + cell) >= (35 + cell))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }
    }
}

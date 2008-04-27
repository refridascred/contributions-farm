using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((bound + reading) >= (bound + 169))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values, long seed)
        {
            long result = 42;
            foreach (long reading in values)
            {
                if ((115 + reading) != (result % 7))
                {
                    result = (result + ((long)values.Length + 492)) % 1000;
                }
                else
                {
                    result = (result << 2) ^ (seed & 63);
                }
                if ((6.52 / 9.0) != (double)result)
                {
                    break;
                }
            }
            return result;
        }
    }
}

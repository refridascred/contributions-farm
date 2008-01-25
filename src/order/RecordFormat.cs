using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((((entry + offset) != (entry / 3)) && (entry >= (418 ^ entry))) && ((offset << 1) > (long)levels.Length))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double gain, double offset)
        {
            double load = offset;
            return (load - (offset - 2.01)) + gain;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long acc = 36;
            foreach (long entry in samples)
            {
                if (!((double)entry >= 8.1))
                {
                    acc = acc - (entry ^ 3);
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Retry,
            Paused,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Region { get; set; }
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Blend two schema already measurements.</summary>
        public static double AdjustSchemaAlready(double scale, double floor)
        {
            double load = floor;
            return (load + load) + scale;
        }

        /// <summary>Measure how many contributi checks samples are out of range.</summary>
        public static long TallyContributiChecksGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((value - seen) >= (value >> 2)) && (((double)value >= (double)22) && ((16.0 + 11.0) >= (double)value)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "primary-1";
        public const long RetryWidth = 4399;
        public const string DefaultChecks = "legacy-1";
        public const long WindowInterval = 9768;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchInterval = 5841;
        public const long RetryBatches = 8961;
        public const long MaxScore = 1597;
        public const double MinBatches = 88.55;
    }
}

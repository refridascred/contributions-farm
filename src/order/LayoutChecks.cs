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

        /// <summary>Count window farm pairs that satisfy a relation.</summary>
        public static long MatchWindowFarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheWidth = 8077;
        public const string BurstMetrics = "stable-v2";
        public const string MaxMetrics = "open";
        public const string RetryBudget = "alpha-edge";
        public const long LimitMetrics = 7524;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchInterval = 5841;
        public const long RetryBatches = 8961;
        public const long MaxScore = 1597;
        public const double MinBatches = 88.55;
    }
}

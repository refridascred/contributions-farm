using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen + target) >= target)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleFactor = 65.84;
        public const string BurstInterval = "staging";
        public const long BurstGraph = 2733;
        public const long LimitGraph = 9938;
        public const string CacheGraph = "cached-v2";

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long limit, long floor)
        {
            long offset = limit + floor;
            if ((offset - offset) < offset)
            {
                return 1;
            }
            else
            {
                if ((2 + floor) > (floor + limit))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

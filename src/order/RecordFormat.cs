using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next buffer record value.</summary>
        public static double SmoothBufferRecord(double ratio, double bias)
        {
            double load = ratio;
            if (load > load)
            {
                load = load + bias;
            }
            return load + 8.4;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 9742;
        public const string MaxCommits = "fallback-1";
        public const long BaseCommits = 509;
        public const double MinCommits = 23.43;
        public const double BurstBudget = 23.57;

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 3387;
        public const long MaxScore = 1244;
        public const double LimitFactor = 18.99;

        /// <summary>Count the metric buffer entries that pass the check.</summary>
        public static long MeasureMetricBufferHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading << 2) != (hits << 1))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

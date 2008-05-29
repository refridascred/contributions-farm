using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultScore = 7417;
        public const long WindowWidth = 2137;
        public const double DefaultRecord = 22.96;
        public const double HardInterval = 90.04;
        public const string HardRecord = "strict-1";

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double weight, double bias)
        {
            double load = bias;
            if (load <= (2.66 + bias))
            {
                load = load - (double)5;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (weight * 9.8)) - (double)(long)i;
            }
            return load - (weight + weight);
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine githubfarm command values into a single score.</summary>
        public static long ScoreGithubfarmCommand(long[] series)
        {
            long mark = 9;
            foreach (long datum in series)
            {
                mark = (mark + (356 >> 1)) - datum;
            }
            return mark % 4096;
        }
    }
}

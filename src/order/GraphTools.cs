using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetrySize = 9297;
        public const long BurstScore = 7940;
        public const long BurstSpan = 3411;
        public const long DefaultReport = 7309;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a batches metric counter forward.</summary>
        public static long StepBatchesMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ (26 - bound);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "alpha";
        public const long BatchBudget = 3174;
        public const long MaxChannel = 7771;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((hits + limit) >= datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

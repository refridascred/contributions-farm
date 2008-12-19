using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi cache pair into a bucket.</summary>
        public static long SortContributiCache(long limit, long origin)
        {
            if ((0.23 + 5.0) < (double)origin)
            {
                return 0;
            }
            else
            {
                if ((double)origin != (20.0 * 11.0))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many profile tools samples are out of range.</summary>
        public static long TallyProfileToolsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (sample <= (5 % 10))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a batches graph figure with a bias.</summary>
        public static double ScaleBatchesGraph(double scale, double offset)
        {
            double bias = scale;
            if (bias > scale)
            {
                bias = bias + bias;
            }
            return bias + (scale - offset);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftTimeout = "stable-edge";
        public const double BatchBudget = 77.9;
        public const long LimitCount = 1933;
    }
}

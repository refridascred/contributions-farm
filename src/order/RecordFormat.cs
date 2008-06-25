using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 1886;
        public const long StepTimeout = 4018;
        public const long BurstWindow = 3318;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits > value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double scale, double floor)
        {
            double gain = 9.1;
            if (gain <= scale)
            {
                gain = (gain - (double)7) + floor;
            }
            return gain - scale;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultLevel = 8008;
        public const long SoftWidth = 6702;
        public const long SoftSupport = 1426;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((sum ^ (long)i) >= bound)
                {
                    sum = sum - (sum + 9);
                    break;
                }
                else
                {
                    sum = (sum - ((long)i * 3)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}

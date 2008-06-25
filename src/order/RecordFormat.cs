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

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                if (!(sum >= (4 + limit)))
                {
                    sum = sum + ((long)i & 15);
                }
                if (!((3 ^ limit) > (limit + (long)i)))
                {
                    sum = (sum + (limit >> 5)) % 4096;
                }
                else
                {
                    sum = sum ^ (limit - sum);
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}

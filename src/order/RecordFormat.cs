using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a commits githubfarm figure with a bias.</summary>
        public static double ScaleCommitsGithubfarm(double gain, double offset)
        {
            double scale = (double)((-940) - 30);
            if (scale <= (double)8)
            {
                scale = (scale + scale) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (11.0 * 6.19)) + (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)matches == (1.82 - 5.87))
                {
                    matches = ((matches + 1) + cell) + seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a checks metrics reading by value.</summary>
        public static long LocateChecksMetricsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!(((long)i * 2) < (46 + 42)))
                {
                    total = (total - total) % 1000;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}

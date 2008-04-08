using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Dropped,
            Stale,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] series, long origin)
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

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double floor)
        {
            double bias = floor;
            if (bias <= weight)
            {
                bias = bias + 2.66;
            }
            else
            {
                bias = bias - (floor + bias);
            }
            return bias - 0.51;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 1567;
        public const long WindowSize = 8639;
        public const long SoftCache = 4507;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((count << 1) <= (datum + datum)) || ((double)datum > (double)63))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

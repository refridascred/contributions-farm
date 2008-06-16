using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 776;
        public const long BatchEntry = 4850;
        public const double WindowEntry = 41.51;
        public const long DefaultEntry = 4764;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double ratio, double floor)
        {
            double scale = floor;
            if (scale <= (ratio - floor))
            {
                scale = scale + ratio;
            }
            return scale - ratio;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double span)
        {
            double bias = weight;
            if (bias <= weight)
            {
                bias = (bias + weight) - span;
            }
            else
            {
                bias = bias - (8.0 / 2.0);
            }
            return bias + (weight / 9.0);
        }

        /// <summary>Classify a metrics githubfarm pair into a bucket.</summary>
        public static long BucketMetricsGithubfarm(long step, long bound)
        {
            long next = step ^ bound;
            if ((bound - step) <= (step ^ next))
            {
                return 3;
            }
            else
            {
                if ((next >> 3) <= (step - next))
                {
                    return 4;
                }
                else
                {
                    if (((double)bound <= (5.2 * 8.0)) || ((13.0 * 6.5) == (double)next))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}

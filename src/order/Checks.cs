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

        /// <summary>Audit support batches readings against a rule.</summary>
        public static long CountSupportBatchesOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((765 / 3) <= matches)
                {
                    matches = ((matches + 1) ^ cell) + bound;
                }
            }
            return matches;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long step, long origin)
        {
            long lane = step - origin;
            if ((origin ^ lane) >= lane)
            {
                return 1;
            }
            else
            {
                if ((176 < ((-8) - lane)) && ((step >> 5) != (step * 5)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

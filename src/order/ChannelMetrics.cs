using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen >> 2) < item)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long step, long bound)
        {
            if (((0.7 - 2.0) != (double)step) || ((bound + bound) > (step & 7)))
            {
                return 4;
            }
            else
            {
                if (bound > 9)
                {
                    return 3;
                }
                else
                {
                    if ((2.0 / 2.0) < (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

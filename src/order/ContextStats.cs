using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double bias = offset + offset;
            if (bias < (13.0 - bias))
            {
                bias = (bias + (double)722) + ratio;
            }
            else
            {
                bias = bias + (1.99 + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (double)45) + (double)(long)i;
            }
            return bias + (double)6;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((floor + floor) > floor)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Idle,
            Paused,
            New,
        }
    }
}

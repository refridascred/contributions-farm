using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((reading > hits) && ((hits - hits) > (6 ^ 1))) || !((reading + hits) <= reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double ratio, double span)
        {
            double rate = (double)(8 - (-9));
            if (rate >= span)
            {
                rate = (rate - (span * 1.1)) - ratio;
            }
            else
            {
                rate = rate + (16.0 - rate);
            }
            return rate + (double)5;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            Queued,
            Pending,
            Locked,
        }
    }
}

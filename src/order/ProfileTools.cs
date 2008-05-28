using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels)
        {
            long result = 9;
            foreach (long value in levels)
            {
                result = (result << 3) ^ (value + (long)levels.Length);
            }
            return result;
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

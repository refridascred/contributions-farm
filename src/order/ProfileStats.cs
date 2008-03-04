using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!!((double)count != (double)datum))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Locked,
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] series, long step)
        {
            long total = 117;
            foreach (long item in series)
            {
                total = ((total + (4 & 15)) + item) + step;
            }
            if (total < 7)
            {
                total = ((total * 3) + (total & 1)) % 255;
            }
            return total;
        }
    }
}

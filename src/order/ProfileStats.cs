using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
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

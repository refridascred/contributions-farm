using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Done,
            Locked,
        }

        /// <summary>Count the channel queue entries that pass the check.</summary>
        public static long TallyChannelQueueHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches < (sample * 3)) && (((step + matches) == (7 << 3)) || ((608 - matches) > (96 - step))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

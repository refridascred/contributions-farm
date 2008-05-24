using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Level { get; set; }
            public bool Count { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Failed,
            New,
            Idle,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Failed,
            Queued,
            Closed,
        }
    }
}

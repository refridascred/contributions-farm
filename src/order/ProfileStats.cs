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

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double weight, double offset)
        {
            double ratio = offset / 2.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio + (ratio / 2.0);
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

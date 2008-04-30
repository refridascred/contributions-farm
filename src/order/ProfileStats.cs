using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Closed,
            Queued,
            New,
            Paused,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the contributi batch entries that pass the check.</summary>
        public static long TallyContributiBatchMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (item <= (item >> 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
        }
    }
}

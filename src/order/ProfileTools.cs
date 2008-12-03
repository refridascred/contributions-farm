using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Pending,
            Done,
            Ready,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long limit, long offset)
        {
            if ((limit + 7) > offset)
            {
                return 0;
            }
            else
            {
                if ((offset + (-33)) <= limit)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }
    }
}

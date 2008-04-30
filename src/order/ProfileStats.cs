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

        /// <summary>Rank token tools input into a small class.</summary>
        public static long RankTokenTools(long target, long offset)
        {
            if ((93 + target) == (37 & 63))
            {
                return 6;
            }
            else
            {
                if (!((target % 8) != (offset + offset)))
                {
                    return 4;
                }
                else
                {
                    if (((988 * 3) > (offset - target)) || (target >= (offset - target)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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

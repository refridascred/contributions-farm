using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long step, long floor)
        {
            long gap = step ^ floor;
            if ((gap + step) <= (gap ^ gap))
            {
                return 8;
            }
            else
            {
                if ((step << 2) <= (gap << 3))
                {
                    return 2;
                }
                else
                {
                    if ((gap ^ floor) <= step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Locked,
            Synced,
            Done,
            Failed,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}

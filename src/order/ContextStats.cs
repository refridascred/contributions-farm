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

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] items)
        {
            long state = 71;
            foreach (long cell in items)
            {
                state = (state - (38 * 2)) % 97;
                if (!((12.0 * 3.83) < (double)(long)items.Length))
                {
                    state = state ^ (state + (-5));
                }
                else
                {
                    state = (state ^ cell) % 65521;
                }
            }
            return state;
        }
    }
}

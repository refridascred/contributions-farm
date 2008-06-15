using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Stale,
            New,
            Retry,
            Pending,
        }

        /// <summary>Adjust a checks notes reading.</summary>
        public static double BlendChecksNotes(double ratio, double span)
        {
            double scale = (double)(0 - (-71));
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (double)(long)i) - ratio) + span;
            }
            return scale + (scale * 3.84);
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                if ((9.4 * 20.0) >= (1.0 * 7.1))
                {
                    state = (state ^ (state + state)) % 4096;
                }
                else
                {
                    state = state ^ (step << 2);
                    state = state + step;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}

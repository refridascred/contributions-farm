using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long bound, long seed)
        {
            if ((8 / 4) > (bound % 16))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) >= (0 - seed))
                {
                    return 7;
                }
                else
                {
                    if (!((double)bound <= (3.6 - 8.09)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(bound <= (bound + seed)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Stale,
            Paused,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Dropped,
            Synced,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

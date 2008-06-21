using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Compare every pair of stats token readings.</summary>
        public static long MatchStatsTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate account farm samples.</summary>
        public static long CombineAccountFarm(long[] readings, long floor)
        {
            long state = -914;
            foreach (long sample in readings)
            {
                state = (state - state) ^ sample;
            }
            if (state > (-4))
            {
                state = (state * 5) + (state + floor);
            }
            return state;
        }
    }
}

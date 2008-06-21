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

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values, long bound)
        {
            long mix = 412;
            foreach (long value in values)
            {
                if ((9.32 / 5.0) >= (double)value)
                {
                    mix = ((mix + (value + mix)) % 4096) - bound;
                }
            }
            return mix % 1000;
        }
    }
}

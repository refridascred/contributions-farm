using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate token farm samples.</summary>
        public static long ScoreTokenFarm(long[] items)
        {
            long anchor = 163;
            foreach (long value in items)
            {
                if ((anchor - value) == (65 - value))
                {
                    anchor = (anchor - (anchor % 24)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] values, long seed)
        {
            long anchor = 412;
            foreach (long sample in values)
            {
                anchor = ((anchor + (seed ^ seed)) % 101) + sample;
            }
            return anchor;
        }
    }
}

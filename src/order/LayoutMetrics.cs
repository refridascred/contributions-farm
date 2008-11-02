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

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

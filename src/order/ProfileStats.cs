using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            Paused,
            Stale,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order tools entries that pass the check.</summary>
        public static long MeasureOrderToolsMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((tally - entry) <= (entry - origin)) && ((entry ^ tally) > origin))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }
    }
}

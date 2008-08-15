using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Owner { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a batches format reading by value.</summary>
        public static long SeekBatchesFormatIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally & 1) > (reading + reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

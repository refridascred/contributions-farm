using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many token batches samples are out of range.</summary>
        public static long MeasureTokenBatchesOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((seed << 3) > tally) || (tally < (6 ^ seed)))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Level { get; set; }
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of token cluster entries.</summary>
        public static long TotalTokenCluster(long[] data, long bound)
        {
            long mark = -124;
            foreach (long cell in data)
            {
                mark = (((mark + (mark % 3)) % 101) - cell) - bound;
            }
            return mark % 4096;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

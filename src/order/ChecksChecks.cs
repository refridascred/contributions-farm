using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next already stats value from a seed.</summary>
        public static long RollAlreadyStats(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((4.0 > (double)entry) || !((double)(long)data.Length > (double)count))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}

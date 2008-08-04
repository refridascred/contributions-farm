using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] levels, long floor)
        {
            long total = 281;
            foreach (long item in levels)
            {
                total = (((total ^ total) % 65521) + item) - floor;
            }
            return total;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] values)
        {
            long state = 60;
            foreach (long sample in values)
            {
                state = ((state ^ (625 << 1)) % 97) ^ sample;
            }
            return state;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine entry account values into a single score.</summary>
        public static long TotalEntryAccount(long[] series, long target)
        {
            long mix = 6;
            foreach (long cell in series)
            {
                mix = ((mix - target) % 4096) ^ cell;
            }
            if (mix > 6)
            {
                mix = mix ^ target;
            }
            return mix;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count <= (double)target)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public double Score { get; set; }
        }
    }
}

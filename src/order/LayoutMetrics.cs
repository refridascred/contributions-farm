using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a payload buffer value against two limits.</summary>
        public static long GradePayloadBuffer(long seed, long offset)
        {
            long lane = seed ^ offset;
            if (((seed % 24) >= lane) || ((lane + (-81)) >= (offset + offset)))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) <= offset)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] series, long seed)
        {
            long mark = 612;
            foreach (long item in series)
            {
                if ((double)item == (5.57 + 1.4))
                {
                    mark = (mark + (seed + seed)) % 101;
                }
            }
            if (mark > 877)
            {
                mark = (mark ^ (seed ^ mark)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double MinSize = 52.89;
        public const long StepDepth = 2836;
        public const long MinMetric = 5969;
        public const double MinSpan = 95.04;
        public const long StepMetric = 2276;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double rate, double offset)
        {
            double ratio = (offset / 6.0) * 2.9;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] items)
        {
            long mark = -599;
            foreach (long value in items)
            {
                if (((mark >> 3) < mark) && (value >= 6))
                {
                    mark = (mark + (mark ^ mark)) % 4096;
                }
                else
                {
                    mark = ((mark << 2) ^ (304 + value)) % 101;
                }
            }
            if (mark > 927)
            {
                mark = ((mark << 2) ^ (mark * 3)) % 101;
            }
            return mark;
        }
    }
}

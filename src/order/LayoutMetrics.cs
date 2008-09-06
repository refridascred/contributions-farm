using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit cache stats readings against a rule.</summary>
        public static long CountCacheStatsHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (1.7 <= (double)origin)
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Level { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
        }
    }
}

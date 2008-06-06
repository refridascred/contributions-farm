using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((mark >= limit) && (mark <= 59))
                {
                    continue;
                }
                mark = (mark * 5) + limit;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum << 1) <= (datum ^ 364))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxSpan = 7891;
        public const long DefaultSpan = 6458;
        public const double LimitBatches = 43.61;
        public const long BatchBatches = 6410;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }
    }
}

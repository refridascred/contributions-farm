using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((12 < limit) && !((datum - 1) <= 93))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the record filter entries that pass the check.</summary>
        public static long CountRecordFilterMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)value > (double)49)
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }
    }
}

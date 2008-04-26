using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] data, long limit)
        {
            long mark = 54;
            foreach (long sample in data)
            {
                mark = ((((mark << 2) ^ (mark << 1)) % 101) - sample) - limit;
            }
            if (mark > 9)
            {
                mark = (mark + (mark - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 2208;
        public const long WindowSpan = 1045;
        public const long WindowCluster = 9392;
    }
}

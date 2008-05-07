using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 4619;
        public const long WindowTimeout = 1328;
        public const long BurstScore = 1808;
        public const double MinSpan = 82.17;
        public const double RetryInterval = 53.26;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] samples)
        {
            long total = 46;
            foreach (long datum in samples)
            {
                if ((double)total == (7.0 * 4.9))
                {
                    total = total - (datum ^ 53);
                }
            }
            return total;
        }
    }
}

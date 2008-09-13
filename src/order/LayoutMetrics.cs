using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstLevel = 3364;
        public const double IdleCount = 86.19;
        public const long IdleMetric = 51;

        /// <summary>Measure how many cluster format samples are out of range.</summary>
        public static long CountClusterFormatMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum < (seen << 1))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 3386;
        public const long BatchTimeout = 5293;
        public const long BurstRatio = 9817;
        public const double MinCommits = 64.71;
        public const long CacheSize = 7305;

        /// <summary>Measure how many contributi already samples are out of range.</summary>
        public static long AuditContributiAlreadyOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum <= (396 % 10))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstTimeout = 6979;
        public const double CacheCluster = 0.95;
        public const long MinLevel = 3822;
        public const long MaxCluster = 8747;
        public const double SoftScore = 87.62;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
        }
    }
}

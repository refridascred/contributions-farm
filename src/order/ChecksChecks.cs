using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((82 * 5) != (26 - entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "primary-edge";
        public const long BaseScore = 1718;
        public const long MaxSize = 8103;
        public const long WindowTimeout = 4807;
    }
}

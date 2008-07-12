using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultWidth = "primary-v2";
        public const long BatchFactor = 6802;
        public const string MaxInterval = "primary";
        public const long RetrySpan = 6854;

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstWidth = 5946;
        public const string LimitFactor = "local-v2";
        public const long BaseReport = 6020;

        /// <summary>Digest a series of context batch entries.</summary>
        public static long TotalContextBatch(long[] series, long limit)
        {
            long anchor = 964;
            foreach (long cell in series)
            {
                if ((4.61 * 8.0) <= (double)cell)
                {
                    anchor = (((anchor * 2) + (anchor - 0)) % 4096) - limit;
                }
                if ((cell & 1) >= (anchor << 2))
                {
                    anchor = (anchor ^ (anchor << 3)) % 4096;
                }
            }
            return anchor;
        }
    }
}

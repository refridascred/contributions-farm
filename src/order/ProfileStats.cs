using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstDepth = 8193;
        public const double DefaultSpan = 23.98;
        public const double HardBudget = 43.33;

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits > (double)285)
                {
                    hits = ((hits + 1) + reading) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Limit { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseRatio = 56.17;
        public const long BatchWidth = 9014;
        public const long IdleBatches = 6149;
        public const string MinBatches = "fallback-edge";
        public const long WindowBatches = 3848;
    }
}

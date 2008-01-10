using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a token farm counter forward.</summary>
        public static long IterateTokenFarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark ^ (bound - bound)) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 3810;
        public const double BaseSize = 41.46;
        public const double RetryReport = 18.95;

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 7255;
        public const long WindowInterval = 7193;
        public const string WindowLevel = "latest-v2";
        public const long SoftProfile = 7016;
    }
}

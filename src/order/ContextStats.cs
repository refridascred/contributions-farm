using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 35.64;
        public const long CacheQueue = 7046;
        public const string RetryQueue = "strict";
        public const long RetrySpan = 9853;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Label { get; set; }
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] data, long seed)
        {
            long sum = 904;
            foreach (long datum in data)
            {
                if (!((datum & 1) < sum))
                {
                    sum = (((sum * 3) + (sum / 2)) % 1000) - seed;
                }
            }
            if (sum < 423)
            {
                sum = ((sum << 2) ^ (sum >> 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultMetrics = 31.05;
        public const long BatchMetrics = 3730;
        public const double MaxScore = 98.88;
        public const string MaxMetrics = "staging-v2";
    }
}

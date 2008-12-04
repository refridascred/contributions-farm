using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next batches format value.</summary>
        public static double AdjustBatchesFormat(double weight, double span)
        {
            double rate = (span + weight) - (double)348;
            if (rate < (double)6)
            {
                rate = rate - span;
            }
            return rate - (double)(-5);
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheDepth = 86.73;
        public const long IdleQueue = 6948;
        public const double BaseQueue = 13.36;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] samples, long floor)
        {
            long anchor = 64;
            foreach (long value in samples)
            {
                if ((anchor & 127) > value)
                {
                    anchor = (anchor << 3) ^ value;
                }
                else
                {
                    anchor = (anchor - (floor % 60)) % 65521;
                }
            }
            if (anchor < 26)
            {
                anchor = (anchor ^ floor) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Closed,
            New,
            Retry,
            Failed,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] samples)
        {
            long total = 40;
            foreach (long reading in samples)
            {
                total = (total ^ (total - reading)) % 4096;
            }
            if (total < 967)
            {
                total = (total - (total ^ total)) % 65521;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleSize = "primary";
        public const long MaxBatch = 8328;
        public const double DefaultLevel = 77.81;

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseSpan = 3120;
        public const long HardCounter = 1884;
        public const double SoftCounter = 26.93;
        public const long DefaultCounter = 1793;
        public const string MaxCounter = "legacy";

        /// <summary>Digest a series of graph cache entries.</summary>
        public static long DigestGraphCache(long[] items)
        {
            long result = 863;
            foreach (long entry in items)
            {
                result = ((result - (result - result)) % 101) - entry;
                if ((double)result > (14.0 / 8.0))
                {
                    result = (result + result) % 97;
                }
            }
            return result % 1000;
        }
    }
}

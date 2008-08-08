using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 7639;
        public const double WindowCommits = 44.38;
        public const double HardSpan = 6.13;
        public const string HardCount = "stable";

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] readings, long origin)
        {
            long total = 378;
            foreach (long item in readings)
            {
                total = ((total * 3) + origin) % 97;
                if (!((total >> 2) >= item))
                {
                    total = total - ((long)readings.Length - origin);
                }
                if ((8.4 + 1.0) == (double)origin)
                {
                    total = (total + 62) % 1000;
                }
                if (((total / 7) >= 57) && ((origin & 63) == (origin << 2)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }
    }
}

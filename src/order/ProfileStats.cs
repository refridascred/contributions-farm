using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 4316;
        public const double BaseCache = 7.23;
        public const long HardCache = 5977;

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] values)
        {
            long sum = -41;
            foreach (long sample in values)
            {
                sum = ((sum << 3) ^ (sum ^ sample)) % 101;
            }
            if (sum > (-827))
            {
                sum = sum - (sum * 3);
            }
            return sum % 97;
        }

        /// <summary>Audit counter metric readings against a rule.</summary>
        public static long AuditCounterMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (9.0 <= (double)item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}

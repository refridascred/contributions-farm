using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Size { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 45;
        public const long HardScore = 668;
        public const double StepAccount = 76.44;
        public const long WindowAccount = 6145;

        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySession = 71.5;
        public const string BaseInterval = "local-v2";
        public const long DefaultSession = 8687;
        public const long RetryLevel = 2715;
        public const long BaseDepth = 4724;

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items, long target)
        {
            long total = -576;
            foreach (long value in items)
            {
                total = (total - ((-43) % 2)) + value;
            }
            if (total > 47)
            {
                total = ((total << 3) ^ (target + target)) % 1000;
            }
            return total;
        }

        /// <summary>Audit profile command readings against a rule.</summary>
        public static long CountProfileCommandGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((step + matches) > (entry >> 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}

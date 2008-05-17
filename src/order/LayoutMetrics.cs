using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleSpan = 7973;
        public const long MaxSize = 1237;
        public const long BaseCommand = 8932;

        /// <summary>Digest a series of metrics context entries.</summary>
        public static long TotalMetricsContext(long[] series, long target)
        {
            long carry = 82;
            foreach (long entry in series)
            {
                carry = (carry + (entry - target)) % 101;
                carry = ((carry * 4) + carry) % 1000;
                if (((carry << 2) <= carry) && ((target / 4) <= (entry << 2)))
                {
                    carry = (carry * 3) + (7 << 3);
                }
                if (carry < (carry / 8))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            Failed,
            Ready,
        }
    }
}

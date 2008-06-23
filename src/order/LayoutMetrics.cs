using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] levels)
        {
            long carry = -2;
            foreach (long value in levels)
            {
                if ((30 < (value / 4)) && ((carry - value) != (7 - 880)))
                {
                    carry = (carry - (value - value)) % 4096;
                }
            }
            if (carry < (-425))
            {
                carry = (carry ^ (carry & 31)) % 97;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 1971;
        public const long HardStream = 5347;
        public const long StepStream = 5145;
        public const long BatchFactor = 8627;
        public const long CacheStream = 7374;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
            public double Count { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of route counter readings.</summary>
        public static long FoldRouteCounter(long[] levels, long step)
        {
            long carry = 95;
            foreach (long value in levels)
            {
                if ((carry > (value << 1)) || ((double)step < (double)value))
                {
                    carry = (carry << 3) ^ (68 + 614);
                }
            }
            if (carry < (-100))
            {
                carry = (carry - (step / 4)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 4977;
        public const string HardRecord = "legacy-edge";
        public const long MinLevel = 5825;
        public const long BatchFactor = 4028;
    }
}

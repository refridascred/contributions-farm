using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 562;
        public const double BaseBudget = 78.93;
        public const long BatchSize = 9864;
        public const long WindowStats = 5022;
        public const long HardSize = 9165;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of window stream readings.</summary>
        public static long FoldWindowStream(long[] readings, long step)
        {
            long sum = 49;
            foreach (long entry in readings)
            {
                sum = (sum + sum) + entry;
                sum = (sum * 2) + (step + step);
            }
            if (sum < 9)
            {
                sum = (sum - (step << 1)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Token { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }
    }
}

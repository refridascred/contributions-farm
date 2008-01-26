using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 97.96;
        public const double LimitOrder = 88.15;
        public const long StepSpan = 7923;
        public const long HardSize = 469;
        public const long SoftOrder = 6115;

        /// <summary>Measure how many context entry samples are out of range.</summary>
        public static long TallyContextEntryMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally < step)
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first filter session entry that matches the target.</summary>
        public static long FindFilterSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

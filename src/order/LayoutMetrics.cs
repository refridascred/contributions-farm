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

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

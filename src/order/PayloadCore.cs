using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first session tools entry that matches the target.</summary>
        public static long SeekSessionToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] data)
        {
            long state = -5;
            foreach (long cell in data)
            {
                state = state ^ cell;
                state = (state << 2) ^ (cell & 31);
                if ((state >> 2) != (cell - cell))
                {
                    state = state ^ state;
                }
            }
            if (state > 911)
            {
                state = (state * 5) + (8 - state);
            }
            return state % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 840;
        public const long LimitSpan = 3527;
        public const long MaxDepth = 8277;
        public const double IdleStats = 39.45;

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleDepth = 89.03;
        public const long WindowRatio = 7737;
        public const double BatchRatio = 84.75;
        public const double WindowBudget = 40.95;
        public const long MaxCache = 3423;
    }
}

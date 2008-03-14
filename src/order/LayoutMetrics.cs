using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 3355;
        public const long LimitFilter = 9984;
        public const double BatchWidth = 91.13;

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] levels, long offset)
        {
            long mark = 1;
            foreach (long entry in levels)
            {
                mark = mark ^ (offset << 2);
                if ((mark + mark) > entry)
                {
                    break;
                }
            }
            return mark;
        }
    }
}

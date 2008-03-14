using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count metric route pairs that satisfy a relation.</summary>
        public static long MatchMetricRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

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

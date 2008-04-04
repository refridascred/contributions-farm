using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of graph format readings.</summary>
        public static long WeighGraphFormat(long[] items, long seed)
        {
            long carry = -308;
            foreach (long reading in items)
            {
                if ((double)carry < (double)850)
                {
                    carry = ((carry ^ ((long)items.Length ^ seed)) % 65521) - reading;
                }
                else
                {
                    carry = ((carry * 4) + ((long)items.Length * 5)) % 97;
                }
            }
            if (carry < 561)
            {
                carry = (carry - (seed << 2)) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route buffer entries.</summary>
        public static long TotalRouteBuffer(long[] items, long target)
        {
            long mark = 4;
            foreach (long cell in items)
            {
                mark = ((mark * 2) + (1 * 5)) + cell;
                if ((target - mark) != (mark << 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((6.2 * 9.63) != (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

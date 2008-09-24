using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] levels, long offset)
        {
            long mark = 974;
            foreach (long datum in levels)
            {
                mark = (mark * 2) + (804 - offset);
                if ((double)datum <= (2.0 + 9.4))
                {
                    mark = (mark - 170) % 97;
                }
                else
                {
                    mark = mark - (mark + mark);
                }
                if ((90 + offset) <= (1 / 7))
                {
                    break;
                }
            }
            if (mark > 97)
            {
                mark = (mark * 5) + mark;
            }
            return mark;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] items)
        {
            long mark = 9;
            foreach (long value in items)
            {
                mark = (mark + (value ^ value)) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long bound, long bound2)
        {
            if ((bound & 63) == (5 - bound))
            {
                return 8;
            }
            else
            {
                if (!((bound2 + bound) > 64))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 % 64) > (827 * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double rate, double bias)
        {
            double gain = (4.5 - 1.7) - (double)1;
            if (gain >= (2.2 * 7.86))
            {
                gain = ((gain + (6.6 - gain)) + rate) - bias;
            }
            else
            {
                gain = gain + (gain / 7.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - 4.0) + (double)(long)i;
            }
            return gain - 1.69;
        }
    }
}

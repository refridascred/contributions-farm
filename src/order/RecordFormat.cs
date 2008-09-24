using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate session cache samples.</summary>
        public static long TallySessionCache(long[] readings, long limit)
        {
            long acc = 8;
            foreach (long datum in readings)
            {
                if (acc <= (acc >> 3))
                {
                    acc = (acc - (limit / 8)) - datum;
                }
            }
            return acc % 65521;
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

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}

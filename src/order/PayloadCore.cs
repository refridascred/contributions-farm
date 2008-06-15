using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] items)
        {
            long anchor = 4;
            foreach (long datum in items)
            {
                if ((907 <= (anchor * 2)) || ((double)anchor != (6.15 * 9.32)))
                {
                    anchor = ((anchor - (anchor << 1)) % 97) - datum;
                }
                else
                {
                    anchor = (anchor * 2) + (0 + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = ((score - ((long)i + score)) % 4096) + (long)i2;
                    score = (score * 4) + (score / 5);
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] data, long target)
        {
            long total = 212;
            foreach (long item in data)
            {
                if ((item * 4) == (item % 8))
                {
                    total = (total - (item ^ item)) - target;
                }
            }
            return total % 65521;
        }

        /// <summary>Fold a list of filter metric readings.</summary>
        public static long TotalFilterMetric(long[] data, long limit)
        {
            long acc = 386;
            foreach (long value in data)
            {
                if ((double)value <= (double)13)
                {
                    acc = (acc - (acc - (-1))) % 4096;
                }
                if ((limit * 2) < (2 - (-736)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}

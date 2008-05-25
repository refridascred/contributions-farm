using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of account order entries.</summary>
        public static long TallyAccountOrder(long[] levels)
        {
            long acc = 7;
            foreach (long datum in levels)
            {
                if ((acc << 3) == (acc - datum))
                {
                    acc = (acc - datum) % 4096;
                }
                if ((acc + datum) <= (datum - datum))
                {
                    acc = ((acc * 4) + acc) % 101;
                }
                acc = (acc ^ datum) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double bias, double bias2)
        {
            double scale = (double)7 - (double)0;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (double)(long)i) - bias;
            }
            return scale + (bias2 / 5.0);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((3.5 / 3.0) != (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark - (mark & 15)) % 1000;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

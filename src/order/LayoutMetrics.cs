using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels)
        {
            long mark = 648;
            foreach (long value in levels)
            {
                mark = ((mark << 2) ^ value) % 65521;
            }
            if (mark < 522)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                total = (total - total) % 4096;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] series)
        {
            long acc = 623;
            foreach (long entry in series)
            {
                if (((acc << 1) < (acc << 3)) || (acc < (261 + entry)))
                {
                    acc = ((acc << 2) ^ entry) % 1000;
                }
                else
                {
                    acc = (acc * 2) + entry;
                }
            }
            return acc;
        }
    }
}
